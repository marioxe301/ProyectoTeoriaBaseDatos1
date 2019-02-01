using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Empleado : System.Web.UI.Page
{
    string id_empleado;

    protected void Page_Load(object sender, EventArgs e)
    {
        actualizarListas();
        add_Fechas();
        id_empleado = Request.QueryString["valor"];

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter[] pms = new MySqlParameter[5];
        string fecha = DropDownList3.Text + "/" + DropDownList4.Text + "/" + DropDownList5.Text;
        id_empleado = Request.QueryString["valor"];

        pms[0] = new MySqlParameter("NA", MySqlDbType.VarChar);
        pms[0].Value = DropDownList2.Text;
        pms[1] = new MySqlParameter("NP", MySqlDbType.VarChar);
        pms[1].Value = DropDownList6.Text;
        pms[2] = new MySqlParameter("TM", MySqlDbType.VarChar);
        pms[2].Value = TextBox1.Text;
        pms[3] = new MySqlParameter("FC", MySqlDbType.VarChar);
        pms[3].Value = fecha;
        pms[4] = new MySqlParameter("ID", MySqlDbType.VarChar);
        pms[4].Value = id_empleado;

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Ingresar_Horas";

        cmd.Parameters.AddRange(pms);
        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            TextBox1.Text = "";
            actualizarListas();
        }
        else
        {
            TextBox1.Text = "ERROR";
        }
        con.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        GridView1.DataSource = null;
        GridView1.DataBind();
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        con.Open();
        id_empleado = Request.QueryString["valor"];

        MySqlCommand cmd = new MySqlCommand("call ACTxPU('"+id_empleado+"')" ,con);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        actualizarListas();

        GridView1.DataSource = ds;
        GridView1.DataBind();
        cmd.Dispose();
        con.Close();
    }

    public void addAtividades(DropDownList d)
    {
        d.Items.Clear();
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        DataTable dt = new DataTable();
        con.Open();
        id_empleado = Request.QueryString["valor"];
        MySqlDataAdapter adp = new MySqlDataAdapter("call ACTxPU('"+id_empleado+"')", con);
        adp.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
            d.Items.Add(dr["Nombre"].ToString());
        }
        con.Close();
    }
    
    public void addProyectos(DropDownList d)
    {
        d.Items.Clear();
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        DataTable dt = new DataTable();
        con.Open();
        id_empleado = Request.QueryString["valor"];
        MySqlDataAdapter adp = new MySqlDataAdapter("call Listar_PY_Em('" + id_empleado+"')", con);
        adp.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
            d.Items.Add(dr["Nombre"].ToString());
        }
        con.Close();
    }

    public void add_Fechas()
    {
        DropDownList3.Items.Clear();
        DropDownList4.Items.Clear();
        DropDownList5.Items.Clear();

        for (int i = 1; i <= 31; i++)
        {
            DropDownList3.Items.Add(i.ToString());
        }

        for(int i = 1; i <= 12; i++)
        {
            DropDownList4.Items.Add(i.ToString());
        }

        for(int i = 2018; i <= 2200; i++)
        {
            DropDownList5.Items.Add(i.ToString());
        }
    }

    public void actualizarListas()
    {
        DropDownList6.Items.Clear();
        DropDownList2.Items.Clear();
        addProyectos(DropDownList6);
        addAtividades(DropDownList2);
    }

    
}