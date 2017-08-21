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
    public partial class EnviarMensajes : Form
    {
        public EnviarMensajes()
        {
            InitializeComponent();
        }

        private void cargarXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirArchivo = new OpenFileDialog();
            abrirArchivo.Filter = "Archivo XML|*.xml";
            if (abrirArchivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String path = abrirArchivo.FileName;
                string listMsj = Cliente.Connecion.postPeticion("http://127.0.0.1:5000/cargaXML", "path=" + path);
                if (listMsj.Equals("False"))
                {
                    MessageBox.Show("Carga XML fallida");
                }
                else
                {
                    
                    string[] ipMsj = listMsj.Split(';');
                    foreach (string msj in ipMsj)
                    {
                        
                        string[] enviar = msj.Split(',');
                        if (!enviar[0].Equals(""))
                        {
                            string respuesta = Cliente.Connecion.postPeticion("http://" + enviar[0]+ ":5000/mensaje", "inorden=" + enviar[1]);
                            if (respuesta.Trim().ToLower().Equals("false"))
                            {
                                MessageBox.Show("ip:"+ enviar[0]+" mensaje:"+enviar[1]+" Fallido la entrega");
                            }
                            
                        }


                    }
                    
                }
            }
        }

        private void enviarMensajeClosing(object sender, FormClosingEventArgs e)
        {
            AdministrarMensajes ventaAdminMsj = new AdministrarMensajes();
            ventaAdminMsj.Show();
        }

        private void buttonEnviarMsj_Click(object sender, EventArgs e)
        {
            string respuesta = Cliente.Connecion.postPeticion("http://"+textIP.Text.Trim()+":5000/mensaje", "inorden="+textMensaje.Text);
            respuesta = respuesta.ToLower().Trim();
            if (respuesta.Equals("false"))
            {
                MessageBox.Show("Mensaje no entregado");
            }
            else
            {
                MessageBox.Show("Mensaje entregado");
            }
        }
    }
}
