using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AppendOutput(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<string>(AppendOutput), text);
            }
            else
            {
                outTextBox.AppendText(text + Environment.NewLine);
            }
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("The current directory is {0}", path);
            var ps1File = "C:\\Users\\p78511225\\source\\repos\\WindowsFormsApp3\\LabcontrolInstaller.ps1";

            var startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-ExecutionPolicy ByPass -File \"{ps1File}\"",
                UseShellExecute = false,
                Verb = "runas",  // <--- elevation
                RedirectStandardOutput = true,
                RedirectStandardError = true // Needed for ErrorDataReceived
            };
            Process p = Process.Start(startInfo);

            // Use different parameter names in the lambda to avoid CS0136
            p.ErrorDataReceived += new DataReceivedEventHandler((procSender, procE) =>
            {
                // You may want to handle error output here, e.g.:
                if (procE.Data != null)
                {
                    AppendOutput(procE.Data);
                }
            });
            p.BeginErrorReadLine();
            p.OutputDataReceived += new DataReceivedEventHandler((procSender, procE) =>
            {
                // You may want to handle standard output here, e.g.:
                if (procE.Data != null)
                {
                    AppendOutput(procE.Data);
                }
            });
            p.BeginOutputReadLine();
            //p.BeginErrorReadLine();    

            // Synchronously read the standard output of the spawned process.
            //StreamReader reader = p.StandardOutput;
            //string output = reader.ReadToEnd();
            // Write the redirected output to this application's window.
            //Console.WriteLine(output);
            //AppendOutput(output);



        }
    }
}
