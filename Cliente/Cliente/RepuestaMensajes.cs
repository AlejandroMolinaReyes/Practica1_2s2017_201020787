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
    public partial class RepuestaMensajes : Form
    {
        public RepuestaMensajes()
        {
            InitializeComponent();
        }

        private void repuestaMensajesClosing(object sender, FormClosingEventArgs e)
        {
            MenuPrincipal ventanaMenuPrincipal = new MenuPrincipal();
            ventanaMenuPrincipal.Show();
        }

        private void buttonAntiguos_Click(object sender, EventArgs e)
        {
            this.tablaRespuesta.Rows.Clear();
            string respuesta = Cliente.Connecion.getPeticion("http://127.0.0.1:5000/antiguos");
            string[] element = respuesta.Split(';');
            foreach (string datos in element)
            {
                if (!datos.Equals(""))
                {
                    string[] dato = datos.Split(',');
                    this.tablaRespuesta.Rows.Add(dato[0], dato[1], dato[2], dato[3], dato[4]);
                }
            }
        }

        private void buttonRecientes_Click(object sender, EventArgs e)
        {
            this.tablaRespuesta.Rows.Clear();
            string respuesta = Cliente.Connecion.getPeticion("http://127.0.0.1:5000/reciente");
            string[] element = respuesta.Split(';');
            foreach (string datos in element)
            {
                if (!datos.Equals(""))
                {
                    string[] dato = datos.Split(',');
                    this.tablaRespuesta.Rows.Add(dato[0], dato[1], dato[2], dato[3], dato[4]);
                }
            }
        }
    }
}
