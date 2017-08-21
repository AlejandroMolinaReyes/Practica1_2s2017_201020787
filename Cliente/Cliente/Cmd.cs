using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Cliente
{
    class Cmd
    {
        public static String ExecuteCommand(string command)
        {
            try
            {
                ProcessStartInfo procStartInfo = new ProcessStartInfo();
                procStartInfo.FileName = Environment.ExpandEnvironmentVariables("%SystemRoot%") + @"\System32\cmd.exe";
                procStartInfo.Arguments = "/c " + command+ "\"";
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                procStartInfo.CreateNoWindow = true;
                Process proc = new Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                string result = proc.StandardOutput.ReadToEnd();
                return result;
            }
            catch (Exception) {
                return "False";
            }
        }
    }
}
