using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pruebas_visuales
{
    public partial class FrmFormato_Texto : Form
    {
        public FrmFormato_Texto()
        {
            InitializeComponent();
        }

        private void chk_negrita_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_negrita.Checked)
                lbl_vista_previa.Font=new Font( lbl_vista_previa.Font, FontStyle.Bold );
            else
                lbl_vista_previa.Font = new Font(lbl_vista_previa.Font, FontStyle.Regular);
        }

        private void chk_cursiva_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_cursiva.Checked)
                lbl_vista_previa.Font = new Font(lbl_vista_previa.Font, FontStyle.Italic);
            else
                lbl_vista_previa.Font = new Font(lbl_vista_previa.Font,FontStyle.Regular);
        }

        private void cbx_tamanio_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_vista_previa.Font = new Font(lbl_vista_previa.Font.FontFamily, Convert.ToInt32(cbx_tamanio.Text));
        }

        private void btn_examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.ShowDialog();
            txt_archivo_imagen.Text = archivo.FileName;
            pic_imagen.ImageLocation = archivo.FileName;

            this.BackgroundImage = Image.FromFile(archivo.FileName);


        }
    }
}
