using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
           
    
        DropDownList4.Items.Add("interno");
        DropDownList4.Items.Add("externo");

        DropDownList5.Items.Add("not_started");
        DropDownList5.Items.Add("on_track");
        DropDownList5.Items.Add("slipping");
        DropDownList5.Items.Add("on_hold");
        DropDownList5.Items.Add("off_track");
        DropDownList5.Items.Add("done");

        DropDownList14.Items.Add("not_started");
        DropDownList14.Items.Add("on_track");
        DropDownList14.Items.Add("slipping");
        DropDownList14.Items.Add("on_hold");
        DropDownList14.Items.Add("off_track");
        DropDownList14.Items.Add("done");

        DropDownList15.Items.Add("Hardware");
        DropDownList15.Items.Add("Software");

        addClientesToList(DropDownList1);
        addClientesToList(DropDownList2);

        addEmpleadosToList(DropDownList7);
        addEmpleadosToList(DropDownList11);
        addEmpleadosToList(DropDownList12);
        addEmpleadosToList(DropDownList21);
        addEmpleadosToList(DropDownList17);

        addProyectosToList(DropDownList8);
        addProyectosToList(DropDownList13);
        addProyectosToList(DropDownList19);
        addProyectosToList(DropDownList22);

        addODToList(DropDownList3);

        addEquipoToList(DropDownList10);

        addEquipoTToList(DropDownList9);
        addEquipoTToList(DropDownList6);

        addActiToList(DropDownList20);

        addHRToList(DropDownList16);
        addHRToList(DropDownList18);


    }

    public void addClientesToList(DropDownList d)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        DataTable dt = new DataTable();
        con.Open();
        MySqlDataAdapter adp = new MySqlDataAdapter("call test_db.Listar_Clientes()", con);
        adp.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
            d.Items.Add(dr["Nombre"].ToString());
           
        }
        con.Close();
    } //r

    public void addEmpleadosToList(DropDownList d)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        DataTable dt = new DataTable();
        con.Open();
        MySqlDataAdapter adp = new MySqlDataAdapter("call test_db.Listar_Empleados()", con);
        adp.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
            d.Items.Add(dr["Nombre"].ToString());
        }
        con.Close();
    } //r

    public void addProyectosToList(DropDownList d)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        DataTable dt = new DataTable();
        con.Open();
        MySqlDataAdapter adp = new MySqlDataAdapter("call test_db.Listar_Proyectos()", con);
        adp.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
            d.Items.Add(dr["Nombre"].ToString());
        }
        con.Close();
    } //r

    public void addEquipoToList(DropDownList d)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        DataTable dt = new DataTable();
        con.Open();
        MySqlDataAdapter adp = new MySqlDataAdapter("call test_db.Listar_Equipo()", con);
        adp.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
            d.Items.Add(dr["Nombre"].ToString());
        }
        con.Close();
    } // r

    public void addEquipoTToList(DropDownList d)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        DataTable dt = new DataTable();
        con.Open();
        MySqlDataAdapter adp = new MySqlDataAdapter("call test_db.Listar_TP()", con);
        adp.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
            d.Items.Add(dr["Nombre"].ToString());
        }
        con.Close();
    } //r

    public void addActiToList(DropDownList d)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        DataTable dt = new DataTable();
        con.Open();
        MySqlDataAdapter adp = new MySqlDataAdapter("call test_db.Listar_Actividades()", con);
        adp.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
            d.Items.Add(dr["Nombre"].ToString());
        }
        con.Close();
    } 

    public void addHRToList(DropDownList d)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        DataTable dt = new DataTable();
        con.Open();
        MySqlDataAdapter adp = new MySqlDataAdapter("call test_db.Listar_HR()", con);
        adp.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
            d.Items.Add(dr["Nombre"].ToString());
        }
        con.Close();
    }

    public void addODToList(DropDownList d)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        DataTable dt = new DataTable();
        con.Open();
        MySqlDataAdapter adp = new MySqlDataAdapter("call test_db.Listar_OD()", con);
        adp.Fill(dt);

        foreach (DataRow dr in dt.Rows)
        {
            d.Items.Add(dr["Nombre"].ToString());
        }
        con.Close();
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter[]pms= new MySqlParameter[6];
        pms[0] = new MySqlParameter("Nom", MySqlDbType.VarChar);
        pms[0].Value = TextBox1.Text;
        pms[1] = new MySqlParameter("Telefono", MySqlDbType.VarChar);
        pms[1].Value = TextBox2.Text;
        pms[2] = new MySqlParameter("Pagina", MySqlDbType.VarChar);
        pms[2].Value = TextBox3.Text;
        pms[3] = new MySqlParameter("Email", MySqlDbType.VarChar);
        pms[3].Value = TextBox4.Text;
        pms[4] = new MySqlParameter("Pais", MySqlDbType.VarChar);
        pms[4].Value = TextBox5.Text;
        pms[5] = new MySqlParameter("Direccion", MySqlDbType.VarChar);
        pms[5].Value = TextBox6.Text;

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Agregar_Cliente";

        cmd.Parameters.AddRange(pms);

        con.Open();
        if(cmd.ExecuteNonQuery() == 1)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";

            ActualizarListas();
        }
        else
        {

        }
        con.Close();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter[] pms = new MySqlParameter[7];
        pms[0] = new MySqlParameter("NomV", MySqlDbType.VarChar);
        pms[0].Value = DropDownList2.Text;
        pms[1] = new MySqlParameter("Nom", MySqlDbType.VarChar);
        pms[1].Value = TextBox1.Text;
        pms[2] = new MySqlParameter("Telef", MySqlDbType.VarChar);
        pms[2].Value = TextBox2.Text;
        pms[3] = new MySqlParameter("Pagina", MySqlDbType.VarChar);
        pms[3].Value = TextBox3.Text;
        pms[4] = new MySqlParameter("Email", MySqlDbType.VarChar);
        pms[4].Value = TextBox4.Text;
        pms[5] = new MySqlParameter("Pai", MySqlDbType.VarChar);
        pms[5].Value = TextBox5.Text;
        pms[6] = new MySqlParameter("Dir", MySqlDbType.VarChar);
        pms[6].Value = TextBox6.Text;
        

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Modificar_Cliente";

        cmd.Parameters.AddRange(pms);

        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = "";

            ActualizarListas();
        }
        else
        {
            TextBox1.Text = "ERROR";
        }
        con.Close();

    }

    public void ActualizarListas()
    {
        DropDownList1.Items.Clear();
        DropDownList2.Items.Clear();
        DropDownList3.Items.Clear();

        DropDownList7.Items.Clear();
        DropDownList11.Items.Clear();
        DropDownList12.Items.Clear();
        DropDownList21.Items.Clear();
        DropDownList17.Items.Clear();
        DropDownList8.Items.Clear();
        DropDownList13.Items.Clear();
        DropDownList19.Items.Clear();
        DropDownList22.Items.Clear();
        DropDownList10.Items.Clear();
        DropDownList9.Items.Clear();
        DropDownList6.Items.Clear();
        DropDownList20.Items.Clear();
        DropDownList16.Items.Clear();
        DropDownList18.Items.Clear();

        DropDownList4.Items.Clear();
        DropDownList4.Items.Clear();

        DropDownList5.Items.Clear();
        DropDownList5.Items.Clear();
        DropDownList5.Items.Clear();
        DropDownList5.Items.Clear();
        DropDownList5.Items.Clear();
        DropDownList5.Items.Clear();

        DropDownList14.Items.Clear();
        DropDownList14.Items.Clear();
        DropDownList14.Items.Clear();
        DropDownList14.Items.Clear();
        DropDownList14.Items.Clear();
        DropDownList14.Items.Clear();
        DropDownList15.Items.Clear();
        DropDownList15.Items.Clear();

        addClientesToList(DropDownList1);
        addClientesToList(DropDownList2);
        addODToList(DropDownList3);

        addEmpleadosToList(DropDownList7);
        addEmpleadosToList(DropDownList11);
        addEmpleadosToList(DropDownList12);
        addEmpleadosToList(DropDownList21);
        addEmpleadosToList(DropDownList17);

        addProyectosToList(DropDownList8);
        addProyectosToList(DropDownList13);
        addProyectosToList(DropDownList19);
        addProyectosToList(DropDownList22);

        addEquipoToList(DropDownList10);

        addEquipoTToList(DropDownList9);
        addEquipoTToList(DropDownList6);

        addActiToList(DropDownList20);

        addHRToList(DropDownList16);
        addHRToList(DropDownList18);

        DropDownList4.Items.Add("interno");
        DropDownList4.Items.Add("externo");

        DropDownList5.Items.Add("not_started");
        DropDownList5.Items.Add("on_track");
        DropDownList5.Items.Add("slipping");
        DropDownList5.Items.Add("on_hold");
        DropDownList5.Items.Add("off_track");
        DropDownList5.Items.Add("done");

        DropDownList14.Items.Add("not_started");
        DropDownList14.Items.Add("on_track");
        DropDownList14.Items.Add("slipping");
        DropDownList14.Items.Add("on_hold");
        DropDownList14.Items.Add("off_track");
        DropDownList14.Items.Add("done");

        DropDownList15.Items.Add("Hardware");
        DropDownList15.Items.Add("Software");
    }

    /*MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
    MySqlParameter[] pms = new MySqlParameter[2];
    pms[0] = new MySqlParameter("", MySqlDbType.VarChar);*/

    protected void Button3_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter[] pms = new MySqlParameter[2];
        pms[0] = new MySqlParameter("NomC", MySqlDbType.VarChar);
        pms[0].Value = DropDownList1.Text;
        pms[1] = new MySqlParameter("NP", MySqlDbType.VarChar);
        pms[1].Value = TextBox9.Text;

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Agregar_Orden";

        cmd.Parameters.AddRange(pms);
        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            TextBox9.Text = "";
            ActualizarListas();
        }
        else
        {
            TextBox9.Text ="ERROR";
        }
        con.Close();
    }


    protected void Button4_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter[] pms = new MySqlParameter[9];
        pms[0] = new MySqlParameter("Nom", MySqlDbType.VarChar);
        pms[0].Value = DropDownList3.Text;
        pms[1] = new MySqlParameter("Ubi", MySqlDbType.VarChar);
        pms[1].Value = TextBox10.Text;
        pms[2] = new MySqlParameter("Tipo", MySqlDbType.VarChar);
        pms[2].Value = DropDownList4.Text;
        pms[3] = new MySqlParameter("url_g", MySqlDbType.VarChar);
        pms[3].Value = TextBox11.Text;
        pms[4] = new MySqlParameter("url_t", MySqlDbType.VarChar);
        pms[4].Value = TextBox12.Text;
        pms[5] = new MySqlParameter("Fecha_S", MySqlDbType.VarChar);
        pms[5].Value = TextBox13.Text;
        pms[6] = new MySqlParameter("Fecha_i", MySqlDbType.VarChar);
        pms[6].Value = TextBox14.Text;
        pms[7] = new MySqlParameter("Fecha_f", MySqlDbType.VarChar);
        pms[7].Value = TextBox15.Text;
        pms[8] = new MySqlParameter("estado", MySqlDbType.VarChar);
        pms[8].Value = DropDownList5.Text;


        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Confirmar_Orden";

        cmd.Parameters.AddRange(pms);

        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox14.Text = "";
            TextBox15.Text = "";

            ActualizarListas();
        }
        else
        {
            TextBox10.Text = "ERROR";
        }
        con.Close();

    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter pms = new MySqlParameter("Nom", MySqlDbType.VarChar);
        pms.Value = DropDownList3.Text;

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Denegar_Orden";

        cmd.Parameters.Add(pms);
        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            TextBox10.Text = "";
            TextBox11.Text = "";
            TextBox12.Text = "";
            TextBox13.Text = "";
            TextBox14.Text = "";
            TextBox15.Text = "";

            ActualizarListas();
        }
        else
        {
            TextBox10.Text = "ERROR";
        }
    }

    protected void Button13_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter[] pms = new MySqlParameter[3];
        pms[0] = new MySqlParameter("NombE", MySqlDbType.VarChar);
        pms[0].Value = DropDownList7.Text;
        pms[1] = new MySqlParameter("NombP", MySqlDbType.VarChar);
        pms[1].Value = DropDownList8.Text;
        pms[2] = new MySqlParameter("NombET", MySqlDbType.VarChar);
        pms[2].Value = DropDownList9.Text;

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Asignar_a_Proyecto";

        cmd.Parameters.AddRange(pms);
        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            ActualizarListas();
        }
        else
        {
            TextBox10.Text = "ERROR";
        }
        con.Close();
    }

    protected void Button10_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter pms = new MySqlParameter();
        pms= new MySqlParameter("Nom", MySqlDbType.VarChar);
        pms.Value = TextBox16.Text;
        
        

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Ingresar_Equipo_T";

        cmd.Parameters.Add(pms);
        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            TextBox16.Text = "";
            ActualizarListas();
        }
        else
        {
            TextBox16.Text = "ERROR";
        }
        con.Close();
    }

    protected void Button11_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter []pms = new MySqlParameter[2];
        pms[0] = new MySqlParameter("NomV", MySqlDbType.VarChar);
        pms[0].Value = DropDownList6.Text;

        pms[0] = new MySqlParameter("NombN", MySqlDbType.VarChar);
        pms[0].Value = TextBox16.Text;


        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Ingresar_Equipo_T";

        cmd.Parameters.Add(pms);
        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            ActualizarListas();
        }
        else
        {
            TextBox16.Text = "ERROR";
        }
        con.Close();
    }

    protected void Button14_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter[] pms = new MySqlParameter[10];
        pms[0] = new MySqlParameter("PN", MySqlDbType.VarChar);
        pms[0].Value = TextBox17.Text;
        pms[1] = new MySqlParameter("SN", MySqlDbType.VarChar);
        pms[1].Value = TextBox18.Text;
        pms[2] = new MySqlParameter("PA", MySqlDbType.VarChar);
        pms[2].Value = TextBox19.Text;
        pms[3] = new MySqlParameter("SA", MySqlDbType.VarChar);
        pms[3].Value = TextBox20.Text;
        pms[4] = new MySqlParameter("Dir", MySqlDbType.VarChar);
        pms[4].Value = TextBox21.Text;
        pms[5] = new MySqlParameter("FechaN", MySqlDbType.VarChar);
        pms[5].Value = TextBox22.Text;
        pms[6] = new MySqlParameter("FechaC", MySqlDbType.VarChar);
        pms[6].Value = TextBox23.Text;
        pms[7] = new MySqlParameter("Sal", MySqlDbType.VarChar);
        pms[7].Value = TextBox24.Text;
        pms[8] = new MySqlParameter("NomE", MySqlDbType.VarChar);
        pms[8].Value = DropDownList10.Text;
        pms[9] = new MySqlParameter("Sup", MySqlDbType.VarChar);
        pms[9].Value = DropDownList11.Text;
        


        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Agregar_Empleado";

        cmd.Parameters.AddRange(pms);

        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            TextBox17.Text = "";
            TextBox18.Text = "";
            TextBox19.Text = "";
            TextBox20.Text = "";
            TextBox21.Text = "";
            TextBox22.Text = "";
            TextBox23.Text = "";
            TextBox24.Text = "";

            ActualizarListas();
        }
        else
        {
            TextBox17.Text = "ERROR";
        }
        con.Close();
    }

    protected void Button15_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter[] pms = new MySqlParameter[10];
        pms[0] = new MySqlParameter("PN", MySqlDbType.VarChar);
        pms[0].Value = TextBox17.Text;
        pms[1] = new MySqlParameter("SN", MySqlDbType.VarChar);
        pms[1].Value = TextBox18.Text;
        pms[2] = new MySqlParameter("PA", MySqlDbType.VarChar);
        pms[2].Value = TextBox19.Text;
        pms[3] = new MySqlParameter("SA", MySqlDbType.VarChar);
        pms[3].Value = TextBox20.Text;
        pms[4] = new MySqlParameter("Dir", MySqlDbType.VarChar);
        pms[4].Value = TextBox21.Text;
        pms[5] = new MySqlParameter("FechaN", MySqlDbType.VarChar);
        pms[5].Value = TextBox22.Text;
        pms[6] = new MySqlParameter("FechaC", MySqlDbType.VarChar);
        pms[6].Value = TextBox23.Text;
        pms[7] = new MySqlParameter("Sal", MySqlDbType.VarChar);
        pms[7].Value = TextBox24.Text;
        pms[8] = new MySqlParameter("NomE", MySqlDbType.VarChar);
        pms[8].Value = DropDownList10.Text;
        pms[9] = new MySqlParameter("Sup", MySqlDbType.VarChar);
        pms[9].Value = DropDownList11.Text;
        pms[10] = new MySqlParameter("NomV", MySqlDbType.VarChar);
        pms[10].Value = DropDownList12.Text;


        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Modificar_Empleado";

        cmd.Parameters.AddRange(pms);

        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            TextBox17.Text = "";
            TextBox18.Text = "";
            TextBox19.Text = "";
            TextBox20.Text = "";
            TextBox21.Text = "";
            TextBox22.Text = "";
            TextBox23.Text = "";
            TextBox24.Text = "";

            ActualizarListas();
        }
        else
        {
            TextBox17.Text = "ERROR";
        }
        con.Close();

    }



    protected void Button17_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter[] pms = new MySqlParameter[2];
        pms[0] = new MySqlParameter("Nom", MySqlDbType.VarChar);
        pms[0].Value = DropDownList13.Text;
        pms[1] = new MySqlParameter("Est", MySqlDbType.VarChar);
        pms[1].Value = DropDownList14.Text;

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Cambiar_Estado_P";

        cmd.Parameters.AddRange(pms);
        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            
            ActualizarListas();
        }
        con.Close();
    }

    protected void Button18_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter[] pms = new MySqlParameter[2];
        pms[0] = new MySqlParameter("Nombre", MySqlDbType.VarChar);
        pms[0].Value = TextBox25.Text;
        pms[1] = new MySqlParameter("Tp", MySqlDbType.VarChar);
        pms[1].Value = DropDownList15.Text;

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Agregar_Heramienta";

        cmd.Parameters.AddRange(pms);
        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            TextBox25.Text = "";
            ActualizarListas();
        }
        else
        {
            TextBox25.Text = "ERROR";
        }
        con.Close();
    }

    protected void Button19_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter[] pms = new MySqlParameter[3];
        pms[0] = new MySqlParameter("Nombre", MySqlDbType.VarChar);
        pms[0].Value = TextBox25.Text;
        pms[1] = new MySqlParameter("Tp", MySqlDbType.VarChar);
        pms[1].Value = DropDownList15.Text;
        pms[2] = new MySqlParameter("NV", MySqlDbType.VarChar);
        pms[2].Value = DropDownList16.Text;

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Modificar_Herramienta";

        cmd.Parameters.AddRange(pms);
        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            TextBox25.Text="";
            ActualizarListas();
        }
        else
        {
            TextBox25.Text="ERROR";
        }
        con.Close();
    }

    protected void Button20_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter[] pms = new MySqlParameter[3];
        pms[0] = new MySqlParameter("NomE", MySqlDbType.VarChar);
        pms[0].Value = DropDownList17.Text;
        pms[1] = new MySqlParameter("HR", MySqlDbType.VarChar);
        pms[1].Value = DropDownList18.Text;
        pms[2] = new MySqlParameter("NP", MySqlDbType.VarChar);
        pms[2].Value = DropDownList19.Text;

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Asignar_Herramienta";

        cmd.Parameters.AddRange(pms);
        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            TextBox25.Text = "";
            ActualizarListas();
        }
        else
        {
            TextBox25.Text = "ERROR";
        }
        con.Close();
    }

    protected void Button23_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter[] pms = new MySqlParameter[2];
        pms[0] = new MySqlParameter("Nom", MySqlDbType.VarChar);
        pms[0].Value = TextBox26.Text;
        pms[1] = new MySqlParameter("Tp", MySqlDbType.VarChar);
        pms[1].Value = TextBox27.Text;

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Agregar_Actividad";

        cmd.Parameters.AddRange(pms);
        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            TextBox26.Text = "";
            TextBox27.Text = "";
            ActualizarListas();
        }
        else
        {
            TextBox25.Text = "ERROR";
        }
        con.Close();
    }

    protected void Button24_Click(object sender, EventArgs e)
    {
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        MySqlParameter[] pms = new MySqlParameter[3];
        pms[0] = new MySqlParameter("NomE", MySqlDbType.VarChar);
        pms[0].Value = DropDownList21.Text;
        pms[1] = new MySqlParameter("NomA", MySqlDbType.VarChar);
        pms[1].Value = DropDownList20.Text;
        pms[2] = new MySqlParameter("NomP", MySqlDbType.VarChar);
        pms[2].Value = DropDownList22.Text;

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = con;
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "Asignar_Actividad";

        cmd.Parameters.AddRange(pms);
        con.Open();
        if (cmd.ExecuteNonQuery() == 1)
        {
            
            ActualizarListas();
        }
        else
        {
            TextBox26.Text = "ERROR";
        }
        con.Close();
    }


    protected void Button6_Click(object sender, EventArgs e)
    {
        GridView1.DataSource = null;
        GridView1.DataBind();
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        con.Open();

        MySqlCommand cmd = new MySqlCommand("call Listar_Clientes()", con);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        GridView1.DataSource = ds;
        GridView1.DataBind();
        cmd.Dispose();
        con.Close();
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        GridView2.DataSource = null;
        GridView2.DataBind();
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        con.Open();

        MySqlCommand cmd = new MySqlCommand("call Clientes_sin_Ordenes()", con);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        GridView2.DataSource = ds;
        GridView2.DataBind();
        cmd.Dispose();
        con.Close();
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        GridView3.DataSource = null;
        GridView3.DataBind();
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        con.Open();

        MySqlCommand cmd = new MySqlCommand("call Clientes_con_Ordenes()", con);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        GridView3.DataSource = ds;
        GridView3.DataBind();
        cmd.Dispose();
        con.Close();
    }

    protected void Button9_Click(object sender, EventArgs e)
    {
        GridView4.DataSource = null;
        GridView4.DataBind();
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        con.Open();

        MySqlCommand cmd = new MySqlCommand("call Clientes_con_proyectos()", con);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        GridView4.DataSource = ds;
        GridView4.DataBind();
        cmd.Dispose();
        con.Close();
    }

    protected void Button12_Click(object sender, EventArgs e)
    {
        GridView5.DataSource = null;
        GridView5.DataBind();
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        con.Open();

        MySqlCommand cmd = new MySqlCommand("call Equipos_de_Trabajo()", con);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        GridView5.DataSource = ds;
        GridView5.DataBind();
        cmd.Dispose();
        con.Close();
    }

    protected void Button16_Click(object sender, EventArgs e)
    {
        GridView6.DataSource = null;
        GridView6.DataBind();
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        con.Open();

        MySqlCommand cmd = new MySqlCommand("call Empleados_x_Equipo()", con);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        GridView6.DataSource = ds;
        GridView6.DataBind();
        cmd.Dispose();
        con.Close();
    }

    protected void Button21_Click(object sender, EventArgs e)
    {
        GridView7.DataSource = null;
        GridView7.DataBind();
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        con.Open();

        MySqlCommand cmd = new MySqlCommand("call Listar_HR()", con);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        GridView7.DataSource = ds;
        GridView7.DataBind();
        cmd.Dispose();
        con.Close();
    }

    protected void Button22_Click(object sender, EventArgs e)
    {
        GridView8.DataSource = null;
        GridView8.DataBind();
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        con.Open();

        MySqlCommand cmd = new MySqlCommand("call Herramienta_x_Equipo_x_Proyecto()", con);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        GridView8.DataSource = ds;
        GridView8.DataBind();
        cmd.Dispose();
        con.Close();
    }

    protected void Button25_Click(object sender, EventArgs e)
    {
        GridView9.DataSource = null;
        GridView9.DataBind();
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        con.Open();

        MySqlCommand cmd = new MySqlCommand("call Actividades_x_Proyecto()", con);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        GridView9.DataSource = ds;
        GridView9.DataBind();
        cmd.Dispose();
        con.Close();
    }

    protected void Button26_Click(object sender, EventArgs e)
    {
        GridView10.DataSource = null;
        GridView10.DataBind();
        MySqlConnection con = new MySqlConnection("server=localhost;user id=root;persistsecurityinfo=True;database=test_db;password=somoslossuper11");
        con.Open();

        MySqlCommand cmd = new MySqlCommand("call Act_x_Proyecto_y_empleados()", con);
        MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);

        GridView10.DataSource = ds;
        GridView10.DataBind();
        cmd.Dispose();
        con.Close();
    }

}