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



        // retornar al formulario PRINCIPAL
        private void btnVolver_Click(object sender, EventArgs e)
        {
            // Se muestra el formulario principal original
            principalOriginal.Show(); 
            this.Hide();
        }


        private void btnSalirInscrip_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // VALIDACIÓN DE DATOS INGRESADOS

            // Todos los campos deben ser completados
            if (txtNombre.Text == "" || txtApellido.Text == "" || cboTipo.Text == "" || 
                txtDocumento.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" ||
                txtEmail.Text == "" || cboApto.Text == "" || dtpFechaNac.Value == DateTime.Today)
            {
                MessageBox.Show("Debe completar todos los datos ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            // El documento solo admite caracteres numéricos
            else if (!int.TryParse(txtDocumento.Text, out _))
            {
                MessageBox.Show("El documento solo permite caracteres numéricos. " +
                    "\n (un máximo de 10 caracteres)",
                    "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDocumento.Focus(); // se enfoca en el campo Documento
            }
            // El Apto médico es obligatorio
            else if (cboApto.Text != "Presentado")
            {
                MessageBox.Show("El Apto Médico es obligatorio!",
                    "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                cboApto.Focus(); // se enfoca en el campo Apto Médico
            }
            // Si las validaciones son correctas se procede con la carga de datos
            else
            {
                string respuesta;
                E_Socio soc = new E_Socio();
                soc.Nombre = txtNombre.Text;
                soc.Apellido = txtApellido.Text;
                soc.Doc = Convert.ToInt32(txtDocumento.Text);
                soc.TDoc = cboTipo.Text;
                soc.FechaNac = dtpFechaNac.Value;
                soc.Direccion = txtDireccion.Text;
                soc.Telefono = txtTelefono.Text;
                soc.Email = txtEmail.Text;
                soc.AptoMedico = (cboApto.Text == "Presentado");

                // instanciamos para usar el metodo dentro de SOCIOS
                Datos.Socios socios = new Datos.Socios();
                respuesta = socios.Nuevo_Socio(soc);

                bool esnumero = int.TryParse(respuesta, out int codigo);
                if (esnumero)
                {
                    if (codigo == 1)
                    {
                        MessageBox.Show("El socio ya existe!", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDocumento.Focus(); // se enfoca en el campo Doc
                    }
                    else
                    {
                        MessageBox.Show("¡Registro exitoso! \n Socio nro " + respuesta, "AVISO DEL SISTEMA",
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
            cboTipo.SelectedIndex = -1;
            cboApto.SelectedIndex = -1;
            dtpFechaNac.Value = DateTime.Today;
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            txtNombre.Focus();
        }

        
    }
}
