using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace agenda
{
    public partial class nuevo_contacto : Form
    {
        public nuevo_contacto()
        {
            InitializeComponent();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //creamos el objeto que establece la conexión con el 
            //sql server
            SqlConnection miConexion = new SqlConnection();
            miConexion.ConnectionString = "Data source=NBRAR\\SQLEXPRESS2008";
            miConexion.ConnectionString += ";Initial catalog=agenda_seminario_2013";
            miConexion.ConnectionString += ";User Id=sa";
            miConexion.ConnectionString += ";Password=123";
            miConexion.Open();

            //creamos el objeto que nos permitirá enviar comandos 
            //al servidor
            SqlCommand miComando = new SqlCommand();
            miComando.Connection = miConexion;
            miComando.CommandType = CommandType.StoredProcedure;
            miComando.CommandText = "dbo.insertar_contacto";

            //creamos los objetos parametros para luego agregarlos
            //al objeto SqlCommand
            SqlParameter paramApellido = new SqlParameter();
            paramApellido.SqlDbType = SqlDbType.VarChar;
            paramApellido.ParameterName = "@ape";
            paramApellido.Value = txtapellido.Text;

            SqlParameter paramNombre = new SqlParameter();
            paramNombre.SqlDbType = SqlDbType.VarChar;
            paramNombre.ParameterName = "@nom";
            paramNombre.Value = txtnombre.Text;

            SqlParameter paramDni = new SqlParameter();
            paramDni.SqlDbType = SqlDbType.Int;
            paramDni.ParameterName = "@dni";
            paramDni.Value =Convert.ToInt32(txtdni.Text);

            //agrego los parametros al sqlcommand
            miComando.Parameters.Add(paramApellido);
            miComando.Parameters.Add(paramNombre);
            miComando.Parameters.Add(paramDni);

            //ejecuto el sqlcommand
            miComando.ExecuteNonQuery();







        }
    }
}
