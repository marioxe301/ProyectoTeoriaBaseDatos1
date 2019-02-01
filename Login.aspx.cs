using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using YourApp.Security.Cryptography;

public partial class _Default : System.Web.UI.Page
{
    RijndaelCrypt rijndaelCrypt= new RijndaelCrypt("h");

    protected void Page_Load(object sender, EventArgs e)
    {
      
        
    }
    /*
    public void BindData()
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        con.Open();

        MySqlCommand cmd = new MySqlCommand("select * from clientes", con);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        gridview1.DataSource = ds;
        gridview1.DataBind();
        cmd.Dispose();
        con.Close();
    }
    */

    protected void Button1_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        con.Open();
        MySqlDataAdapter adp = new MySqlDataAdapter("call test_db.Verificar_Cuenta('" + TB1.Text+ "','" +TB2.Text+"')", con);
        MySqlDataAdapter adp1 = new MySqlDataAdapter("call test_db.Cod_con_Us('" + TB1.Text +"')", con);
        adp.Fill(dt);
        adp1.Fill(dt1);

        foreach (DataRow dr in dt.Rows)
        {
            if (dr["Nombre"].ToString() == "1")
            {
                
                    Response.Redirect("Admin.aspx");

            }
            else if (dr["Nombre"].ToString() == "2")
            {
                foreach (DataRow dr1 in dt1.Rows)
                {
                     Response.Redirect("Empleado.aspx?valor=" + dr1["Nombre"].ToString());
                }
                
            }
            else
            {
                TB1.Text = "Usuario incorrecto";
            }

        }
       
        con.Close();
    }

    
}