namespace Pruebas_visuales
{
    partial class frmpruebas_visuales
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
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnarriba = new System.Windows.Forms.Button();
            this.btnizquierda = new System.Windows.Forms.Button();
            this.btnderecha = new System.Windows.Forms.Button();
            this.btnabajo = new System.Windows.Forms.Button();
            this.btncentrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(34, 59);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(175, 20);
            this.txttitulo.TabIndex = 0;
            this.txttitulo.Text = "Escribe aquí el titulo del formulario";
            this.txttitulo.Click += new System.EventHandler(this.txttitulo_Click);
            this.txttitulo.TextChanged += new System.EventHandler(this.txttitulo_TextChanged);
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Location = new System.Drawing.Point(31, 31);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(38, 13);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "Título:";
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(333, 227);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 2;
            this.btnsalir.Text = "&Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnarriba
            // 
            this.btnarriba.Location = new System.Drawing.Point(151, 85);
            this.btnarriba.Name = "btnarriba";
            this.btnarriba.Size = new System.Drawing.Size(75, 40);
            this.btnarriba.TabIndex = 3;
            this.btnarriba.Text = "Acoplar arriba";
            this.btnarriba.UseVisualStyleBackColor = true;
            this.btnarriba.Click += new System.EventHandler(this.btnarriba_Click);
            // 
            // btnizquierda
            // 
            this.btnizquierda.Location = new System.Drawing.Point(70, 130);
            this.btnizquierda.Name = "btnizquierda";
            this.btnizquierda.Size = new System.Drawing.Size(75, 40);
            this.btnizquierda.TabIndex = 4;
            this.btnizquierda.Text = "Acoplar izquierda";
            this.btnizquierda.UseVisualStyleBackColor = true;
            this.btnizquierda.Click += new System.EventHandler(this.btnizquierda_Click);
            // 
            // btnderecha
            // 
            this.btnderecha.Location = new System.Drawing.Point(232, 130);
            this.btnderecha.Name = "btnderecha";
            this.btnderecha.Size = new System.Drawing.Size(75, 40);
            this.btnderecha.TabIndex = 5;
            this.btnderecha.Text = "Acoplar derecha";
            this.btnderecha.UseVisualStyleBackColor = true;
            this.btnderecha.Click += new System.EventHandler(this.btnderecha_Click);
            // 
            // btnabajo
            // 
            this.btnabajo.Location = new System.Drawing.Point(151, 176);
            this.btnabajo.Name = "btnabajo";
            this.btnabajo.Size = new System.Drawing.Size(75, 38);
            this.btnabajo.TabIndex = 6;
            this.btnabajo.Text = "Acoplar abajo";
            this.btnabajo.UseVisualStyleBackColor = true;
            this.btnabajo.Click += new System.EventHandler(this.btnabajo_Click);
            // 
            // btncentrar
            // 
            this.btncentrar.Location = new System.Drawing.Point(151, 130);
            this.btncentrar.Name = "btncentrar";
            this.btncentrar.Size = new System.Drawing.Size(75, 40);
            this.btncentrar.TabIndex = 7;
            this.btncentrar.Text = "Centrar en pantalla";
            this.btncentrar.UseVisualStyleBackColor = true;
            // 
            // frmpruebas_visuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 262);
            this.Controls.Add(this.btncentrar);
            this.Controls.Add(this.btnabajo);
            this.Controls.Add(this.btnderecha);
            this.Controls.Add(this.btnizquierda);
            this.Controls.Add(this.btnarriba);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.txttitulo);
            this.Name = "frmpruebas_visuales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmpruebas_visuales_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnarriba;
        private System.Windows.Forms.Button btnizquierda;
        private System.Windows.Forms.Button btnderecha;
        private System.Windows.Forms.Button btnabajo;
        private System.Windows.Forms.Button btncentrar;
    }
}

