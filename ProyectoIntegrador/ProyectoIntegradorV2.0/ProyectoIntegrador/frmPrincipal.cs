using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        // variables internas: accesibles desde el ensamblado en el cual están declarados
        internal string? rol;
        internal string? usuario;

        private void frmPincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + "  (" + rol + ")";
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            /* Notifica a todos los surtidores de msjs que deben terminar
            y, a continuación, cierra todas las ventanas de la aplicación */
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            frmInscripcion inscripcion = new frmInscripcion(this);
            inscripcion.Show();
            this.Hide();
        }
    }
}
