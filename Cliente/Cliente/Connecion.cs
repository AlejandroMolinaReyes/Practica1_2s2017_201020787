using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Cliente
{
    class Connecion
    {

        public static string getPeticion(string url)
        {
            string respuesta;
            try
            {
                WebRequest request = WebRequest.Create(url);
                request.Timeout = 50;
                StreamReader reader = new StreamReader(request.GetResponse().GetResponseStream());
                respuesta = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception err) {
                respuesta = "False";
            }
            return respuesta;
        }

        public static string postPeticion(string url, string parametro)
        {
            string respuesta = "";
            try {
                WebRequest request = WebRequest.Create(url);
                request.Timeout = 50;
                request.Method = "POST";
                byte[] byteArray = UTF8Encoding.UTF8.GetBytes(parametro);
                //MessageBox.Show(Encoding.ASCII.GetString(byteArray));
                /*char[] CharArray = parametro.ToCharArray();
                byte[] byteArray = new byte[CharArray.Length];
                for (int i = 0; i < CharArray.Length; i++)
                {
                    byteArray[i] = Convert.ToByte(CharArray[i]);
                    
                }*/
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                respuesta = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception err) {
                respuesta = "False";
            }
            return respuesta;
        }



    }
}
