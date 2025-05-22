using ProyectoIntegrador.Entidades;
using ProyectoIntegrador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace ProyectoIntegrador
{
    public partial class frmInscripcion : Form
    {
        private frmPrincipal principalOriginal;
        public frmInscripcion(frmPrincipal principal)
        {
            InitializeComponent();
            principalOriginal = principal;
        }



        // permite retornar al formulario PRINCIPAL
        private void btnVolver_Click(object sender, EventArgs e)
        {
            principalOriginal.Show(); // Mostramos el formulario principal original
            this.Hide();
        }



        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" ||
            txtDocumento.Text == "" || cboTipo.Text == "" || cboApto.Text == "")
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else if (cboApto.Text != "Presentado")
            {
                MessageBox.Show("El Apto Médico es obligatorio!",
                    "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                string respuesta;
                E_Socio soc = new E_Socio();
                soc.NombreC = txtNombre.Text;
                soc.ApellidoC = txtApellido.Text;
                soc.DocC = Convert.ToInt32(txtDocumento.Text);
                soc.TDocC = cboTipo.Text;
                soc.AptoMedico = cboApto.Text;
                soc.FechaNac = dtpFechaNac.Value;

                // instanciamos para usar el metodo dentro de SOCIOS
                Datos.Socios socios = new Datos.Socios();
                respuesta = socios.Nuevo_Socio(soc);

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("EL SOCIO YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDocumento.Focus();
                    }
                    else
                    {
                        MessageBox.Show("REGISTRO EXITOSO! de socio Nro " + respuesta, "AVISO DEL SISTEMA",
                                        MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
            }
        }



        /* Limpiar los objetos para facilitar un nuevo ingreso  */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            cboTipo.Text = "";
            cboApto.Text = "";
            dtpFechaNac.Value = DateTime.Today;
            txtNombre.Focus();
        }

 
   
    }
}
