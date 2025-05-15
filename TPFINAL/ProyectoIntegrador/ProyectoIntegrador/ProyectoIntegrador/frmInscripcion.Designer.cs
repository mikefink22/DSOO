namespace ProyectoIntegrador
{
    partial class frmInscripcion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInscripcion));
            this.picInscripcion = new System.Windows.Forms.PictureBox();
            this.lblTituloInscripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblFechaNac = new System.Windows.Forms.Label();
            this.lblAptoMedico = new System.Windows.Forms.Label();
            this.cboApto = new System.Windows.Forms.ComboBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picInscripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // picInscripcion
            // 
            this.picInscripcion.Image = ((System.Drawing.Image)(resources.GetObject("picInscripcion.Image")));
            this.picInscripcion.Location = new System.Drawing.Point(11, 12);
            this.picInscripcion.Name = "picInscripcion";
            this.picInscripcion.Size = new System.Drawing.Size(247, 382);
            this.picInscripcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInscripcion.TabIndex = 0;
            this.picInscripcion.TabStop = false;
            // 
            // lblTituloInscripcion
            // 
            this.lblTituloInscripcion.AutoSize = true;
            this.lblTituloInscripcion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloInscripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloInscripcion.Location = new System.Drawing.Point(421, 43);
            this.lblTituloInscripcion.Name = "lblTituloInscripcion";
            this.lblTituloInscripcion.Size = new System.Drawing.Size(244, 25);
            this.lblTituloInscripcion.TabIndex = 1;
            this.lblTituloInscripcion.Text = "INSCRIPCIÓN  DEL  SOCIO\r\n";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(331, 105);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(66, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(331, 151);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 20);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(271, 211);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(68, 20);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo doc";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(517, 210);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(89, 20);
            this.lblDocumento.TabIndex = 5;
            this.lblDocumento.Text = "Documento";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Snow;
            this.txtNombre.Location = new System.Drawing.Point(426, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.Snow;
            this.txtApellido.Location = new System.Drawing.Point(426, 152);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(197, 23);
            this.txtApellido.TabIndex = 7;
            // 
            // txtDocumento
            // 
            this.txtDocumento.BackColor = System.Drawing.Color.Snow;
            this.txtDocumento.Location = new System.Drawing.Point(620, 208);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(138, 23);
            this.txtDocumento.TabIndex = 8;
            // 
            // cboTipo
            // 
            this.cboTipo.BackColor = System.Drawing.Color.Snow;
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Items.AddRange(new object[] {
            "DNI",
            "Pasaporte",
            "Extranjero"});
            this.cboTipo.Location = new System.Drawing.Point(354, 211);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(138, 23);
            this.cboTipo.TabIndex = 9;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRegistrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(615, 339);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(143, 52);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(445, 339);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(143, 52);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(165)))), ((int)(((byte)(132)))));
            this.btnVolver.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(89, 43);
            this.btnVolver.TabIndex = 12;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNac.Location = new System.Drawing.Point(264, 268);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(84, 20);
            this.lblFechaNac.TabIndex = 13;
            this.lblFechaNac.Text = "Fecha Nac.";
            // 
            // lblAptoMedico
            // 
            this.lblAptoMedico.AutoSize = true;
            this.lblAptoMedico.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAptoMedico.Location = new System.Drawing.Point(517, 266);
            this.lblAptoMedico.Name = "lblAptoMedico";
            this.lblAptoMedico.Size = new System.Drawing.Size(97, 20);
            this.lblAptoMedico.TabIndex = 14;
            this.lblAptoMedico.Text = "Apto Médico";
            // 
            // cboApto
            // 
            this.cboApto.BackColor = System.Drawing.Color.Snow;
            this.cboApto.FormattingEnabled = true;
            this.cboApto.Items.AddRange(new object[] {
            "Presentado",
            "No Presentado"});
            this.cboApto.Location = new System.Drawing.Point(620, 263);
            this.cboApto.Name = "cboApto";
            this.cboApto.Size = new System.Drawing.Size(138, 23);
            this.cboApto.TabIndex = 15;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(354, 266);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(138, 23);
            this.dtpFechaNac.TabIndex = 16;
            // 
            // frmInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.cboApto);
            this.Controls.Add(this.lblAptoMedico);
            this.Controls.Add(this.lblFechaNac);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboTipo);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTituloInscripcion);
            this.Controls.Add(this.picInscripcion);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmInscripcion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLUB DEPORTIVO  -  INSCRIPCIÓN";
            ((System.ComponentModel.ISupportInitialize)(this.picInscripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picInscripcion;
        private System.Windows.Forms.Label lblTituloInscripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblFechaNac;
        private System.Windows.Forms.Label lblAptoMedico;
        private System.Windows.Forms.ComboBox cboApto;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
    }
}