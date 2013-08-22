namespace Pruebas_visuales
{
    partial class FrmFormato_Texto
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbx_vista_previa = new System.Windows.Forms.GroupBox();
            this.chk_negrita = new System.Windows.Forms.CheckBox();
            this.lbl_vista_previa = new System.Windows.Forms.Label();
            this.chk_cursiva = new System.Windows.Forms.CheckBox();
            this.Subrayado = new System.Windows.Forms.CheckBox();
            this.cbx_tamanio = new System.Windows.Forms.ComboBox();
            this.lbl_tamaño = new System.Windows.Forms.Label();
            this.btn_examinar = new System.Windows.Forms.Button();
            this.txt_archivo_imagen = new System.Windows.Forms.TextBox();
            this.pic_imagen = new System.Windows.Forms.PictureBox();
            this.gbx_vista_previa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_vista_previa
            // 
            this.gbx_vista_previa.Controls.Add(this.lbl_vista_previa);
            this.gbx_vista_previa.Location = new System.Drawing.Point(12, 91);
            this.gbx_vista_previa.Name = "gbx_vista_previa";
            this.gbx_vista_previa.Size = new System.Drawing.Size(387, 118);
            this.gbx_vista_previa.TabIndex = 0;
            this.gbx_vista_previa.TabStop = false;
            this.gbx_vista_previa.Text = "Vista previa";
            // 
            // chk_negrita
            // 
            this.chk_negrita.AutoSize = true;
            this.chk_negrita.Location = new System.Drawing.Point(62, 23);
            this.chk_negrita.Name = "chk_negrita";
            this.chk_negrita.Size = new System.Drawing.Size(60, 17);
            this.chk_negrita.TabIndex = 1;
            this.chk_negrita.Text = "&Negrita";
            this.chk_negrita.UseVisualStyleBackColor = true;
            this.chk_negrita.CheckedChanged += new System.EventHandler(this.chk_negrita_CheckedChanged);
            // 
            // lbl_vista_previa
            // 
            this.lbl_vista_previa.AutoSize = true;
            this.lbl_vista_previa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vista_previa.Location = new System.Drawing.Point(15, 26);
            this.lbl_vista_previa.Name = "lbl_vista_previa";
            this.lbl_vista_previa.Size = new System.Drawing.Size(71, 13);
            this.lbl_vista_previa.TabIndex = 0;
            this.lbl_vista_previa.Text = "Instituto N°20";
            // 
            // chk_cursiva
            // 
            this.chk_cursiva.AutoSize = true;
            this.chk_cursiva.Location = new System.Drawing.Point(158, 23);
            this.chk_cursiva.Name = "chk_cursiva";
            this.chk_cursiva.Size = new System.Drawing.Size(61, 17);
            this.chk_cursiva.TabIndex = 2;
            this.chk_cursiva.Text = "Cursiva";
            this.chk_cursiva.UseVisualStyleBackColor = true;
            this.chk_cursiva.CheckedChanged += new System.EventHandler(this.chk_cursiva_CheckedChanged);
            // 
            // Subrayado
            // 
            this.Subrayado.AutoSize = true;
            this.Subrayado.Location = new System.Drawing.Point(237, 23);
            this.Subrayado.Name = "Subrayado";
            this.Subrayado.Size = new System.Drawing.Size(77, 17);
            this.Subrayado.TabIndex = 3;
            this.Subrayado.Text = "Subrayado";
            this.Subrayado.UseVisualStyleBackColor = true;
            // 
            // cbx_tamanio
            // 
            this.cbx_tamanio.FormattingEnabled = true;
            this.cbx_tamanio.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "40"});
            this.cbx_tamanio.Location = new System.Drawing.Point(121, 64);
            this.cbx_tamanio.Name = "cbx_tamanio";
            this.cbx_tamanio.Size = new System.Drawing.Size(121, 21);
            this.cbx_tamanio.TabIndex = 4;
            this.cbx_tamanio.SelectedIndexChanged += new System.EventHandler(this.cbx_tamanio_SelectedIndexChanged);
            // 
            // lbl_tamaño
            // 
            this.lbl_tamaño.AutoSize = true;
            this.lbl_tamaño.Location = new System.Drawing.Point(59, 64);
            this.lbl_tamaño.Name = "lbl_tamaño";
            this.lbl_tamaño.Size = new System.Drawing.Size(46, 13);
            this.lbl_tamaño.TabIndex = 5;
            this.lbl_tamaño.Text = "Tamaño";
            // 
            // btn_examinar
            // 
            this.btn_examinar.Location = new System.Drawing.Point(384, 225);
            this.btn_examinar.Name = "btn_examinar";
            this.btn_examinar.Size = new System.Drawing.Size(75, 23);
            this.btn_examinar.TabIndex = 6;
            this.btn_examinar.Text = "Examinar";
            this.btn_examinar.UseVisualStyleBackColor = true;
            this.btn_examinar.Click += new System.EventHandler(this.btn_examinar_Click);
            // 
            // txt_archivo_imagen
            // 
            this.txt_archivo_imagen.Location = new System.Drawing.Point(30, 225);
            this.txt_archivo_imagen.Name = "txt_archivo_imagen";
            this.txt_archivo_imagen.Size = new System.Drawing.Size(332, 20);
            this.txt_archivo_imagen.TabIndex = 7;
            // 
            // pic_imagen
            // 
            this.pic_imagen.Location = new System.Drawing.Point(30, 252);
            this.pic_imagen.Name = "pic_imagen";
            this.pic_imagen.Size = new System.Drawing.Size(168, 110);
            this.pic_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_imagen.TabIndex = 8;
            this.pic_imagen.TabStop = false;
            // 
            // FrmFormato_Texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(497, 374);
            this.Controls.Add(this.pic_imagen);
            this.Controls.Add(this.txt_archivo_imagen);
            this.Controls.Add(this.btn_examinar);
            this.Controls.Add(this.lbl_tamaño);
            this.Controls.Add(this.cbx_tamanio);
            this.Controls.Add(this.Subrayado);
            this.Controls.Add(this.chk_cursiva);
            this.Controls.Add(this.chk_negrita);
            this.Controls.Add(this.gbx_vista_previa);
            this.Name = "FrmFormato_Texto";
            this.Text = "FrmFormato_Texto";
            this.gbx_vista_previa.ResumeLayout(false);
            this.gbx_vista_previa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_vista_previa;
        private System.Windows.Forms.CheckBox chk_negrita;
        private System.Windows.Forms.Label lbl_vista_previa;
        private System.Windows.Forms.CheckBox chk_cursiva;
        private System.Windows.Forms.CheckBox Subrayado;
        private System.Windows.Forms.ComboBox cbx_tamanio;
        private System.Windows.Forms.Label lbl_tamaño;
        private System.Windows.Forms.Button btn_examinar;
        private System.Windows.Forms.TextBox txt_archivo_imagen;
        private System.Windows.Forms.PictureBox pic_imagen;
    }
}