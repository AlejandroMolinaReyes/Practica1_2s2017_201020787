using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class AdministrarMensajes : Form
    {
        public AdministrarMensajes()
        {
            InitializeComponent();
        }

        private void AdminMensajesClosing(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal ventanaMenuPrincipal = new MenuPrincipal();
            ventanaMenuPrincipal.Show();
        }

        private void EnviarMensajes_Click(object sender, EventArgs e)
        {
            this.Dispose();
            EnviarMensajes ventaEnviarMensaje = new EnviarMensajes();
            ventaEnviarMensaje.Show();
            
        }

        private void VerCola_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ColaMensajes ventaColaMensajes = new ColaMensajes();
            ventaColaMensajes.Show();
        }

        private void verRespuestas_Click(object sender, EventArgs e)
        {
            this.Dispose();
            RepuestaMensajes ventaRepuestaMensaje = new RepuestaMensajes();
            ventaRepuestaMensaje.Show();
        }
    }
}
