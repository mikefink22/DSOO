namespace ProyectoIntegrador
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblIngreso = new System.Windows.Forms.Label();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInscribir = new System.Windows.Forms.Button();
            this.btnEmitirCarnet = new System.Windows.Forms.Button();
            this.btnAsignarAct = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngreso.Location = new System.Drawing.Point(26, 24);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(61, 17);
            this.lblIngreso.TabIndex = 0;
            this.lblIngreso.Text = "USUARIO";
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(310, 56);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(171, 25);
            this.lblTituloPrincipal.TabIndex = 1;
            this.lblTituloPrincipal.Text = "MENÚ PRINCIPAL";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(679, 24);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 37);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnInscribir
            // 
            this.btnInscribir.BackColor = System.Drawing.Color.PeachPuff;
            this.btnInscribir.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscribir.Location = new System.Drawing.Point(29, 141);
            this.btnInscribir.Name = "btnInscribir";
            this.btnInscribir.Size = new System.Drawing.Size(244, 79);
            this.btnInscribir.TabIndex = 3;
            this.btnInscribir.Text = "Inscribir  Cliente";
            this.btnInscribir.UseVisualStyleBackColor = false;
            this.btnInscribir.Click += new System.EventHandler(this.btnInscribir_Click);
            // 
            // btnEmitirCarnet
            // 
            this.btnEmitirCarnet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(195)))));
            this.btnEmitirCarnet.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmitirCarnet.Location = new System.Drawing.Point(29, 244);
            this.btnEmitirCarnet.Name = "btnEmitirCarnet";
            this.btnEmitirCarnet.Size = new System.Drawing.Size(244, 79);
            this.btnEmitirCarnet.TabIndex = 4;
            this.btnEmitirCarnet.Text = "Emitir  carnet";
            this.btnEmitirCarnet.UseVisualStyleBackColor = false;
            // 
            // btnAsignarAct
            // 
            this.btnAsignarAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(195)))));
            this.btnAsignarAct.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarAct.Location = new System.Drawing.Point(504, 141);
            this.btnAsignarAct.Name = "btnAsignarAct";
            this.btnAsignarAct.Size = new System.Drawing.Size(244, 79);
            this.btnAsignarAct.TabIndex = 5;
            this.btnAsignarAct.Text = "Asignar actividad";
            this.btnAsignarAct.UseVisualStyleBackColor = false;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.PeachPuff;
            this.btnPagar.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Location = new System.Drawing.Point(504, 244);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(244, 79);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "Pagar ";
            this.btnPagar.UseVisualStyleBackColor = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(774, 395);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.btnAsignarAct);
            this.Controls.Add(this.btnEmitirCarnet);
            this.Controls.Add(this.btnInscribir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Controls.Add(this.lblIngreso);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CLUB DEPORTIVO  -  MENÚ PRINCIPAL";
            this.Load += new System.EventHandler(this.frmPincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Label lblTituloPrincipal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInscribir;
        private System.Windows.Forms.Button btnEmitirCarnet;
        private System.Windows.Forms.Button btnAsignarAct;
        private System.Windows.Forms.Button btnPagar;
    }
}