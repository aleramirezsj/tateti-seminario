//instrucciones que incorporan recursos del lenguaje
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//espacio de nombres que es igual al nombre del proyecto
namespace Pruebas_visuales
{
    //declaración de clase que conforma al formulario
    public partial class frmpruebas_visuales : Form
    {
        //método constructor ATENCIÓN es igual al 
        //nombre de la clase!
        public frmpruebas_visuales()
        {
            InitializeComponent();
            
        }

  

        private void txttitulo_Click(object sender, EventArgs e)
        {
            txttitulo.Text = "";
        }

        private void txttitulo_TextChanged(object sender, EventArgs e)
        {
            this.Text = txttitulo.Text;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnarriba_Click(object sender, EventArgs e)
        {
            this.Top =0;
        }

        private void btnabajo_Click(object sender, EventArgs e)
        {
            this.Top = Screen.PrimaryScreen.WorkingArea.Height-this.Height;
        }

        private void btnizquierda_Click(object sender, EventArgs e)
        {
            this.Left =0;
        }

        private void btnderecha_Click(object sender, EventArgs e)
        {
            this.Left = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
        }

        private void frmpruebas_visuales_Load(object sender, EventArgs e)
        {

        }
    }
}
