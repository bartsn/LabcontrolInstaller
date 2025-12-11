using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp3
{
    // Source - https://stackoverflow.com/a
    // Posted by TaW, modified by community. See post 'Timeline' for change history
    // Retrieved 2025-12-03, License - CC BY-SA 3.0
    
    

    public partial class Form1 : Form
    {
        private StreamWriter myStreamWriter = null;
        private Process p = null;
        private string ps1File = "C:\\github\\LabcontrolInstaller\\src\\LabcontrolInstall\\install_functions.ps1"; 
        private List<string> psResponsLines= new List<string>();
        private List<string> driveList = new List<string>();
        private List<string> driveUsage = new List<string>();
        private List<string> driveFree = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private bool checkDiskSpace(List<string> respLines) {
            // pwsh commando "Get-PSDrive" levert output in 8 kolommen
            int index = 0;
            foreach (string s in respLines) {
                if (index > 13) { 
                    if (index % 7 == 0)
                    {
                        driveList.Add(s);
                    }
                    else if (index % 7 == 1)
                    {
                        driveUsage.Add(s);
                    }
                    else if (index % 7 == 2)
                    {
                        driveFree.Add(s);
                    }
                }
                index++;
            }
            return false; 
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
        private void startPSProcess(String command) {
                var startInfo = new ProcessStartInfo()
            {
                FileName = "powershell.exe",
                Arguments = $"-ExecutionPolicy ByPass -File \"{ps1File}\" {command}",
                //UseShellExecute = false,
                //CreateNoWindow = true,
                Verb = "runas",  // <--- elevation
                //RedirectStandardOutput = true,
                //RedirectStandardError = true, // Needed for ErrorDataReceived
                //RedirectStandardInput = true
            };
            p = Process.Start(startInfo);
            /*
            myStreamWriter = p.StandardInput;

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
                    char[] delimiter = new char[] { ' ' };
                
                    string[] output = procE.Data.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string stringetje in output)
                    {
                        psResponsLines.Add(stringetje); 
                    }
                    
                    AppendOutput(procE.Data);
                }
            });
            p.BeginOutputReadLine();
            */
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            Console.WriteLine("The current directory is {0}", path);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string inputText = commandBox.Text;
            char[] losseTekens = inputText.ToCharArray();   
            if (inputText.Equals(""))
            {
                commandBox.Clear();
                return;
            }
            //clear the reponses before starting a new script.
            psResponsLines.Clear();
            startPSProcess(inputText);
            //myStreamWriter.WriteLine(inputText);
            commandBox.Clear();
            //p.WaitForExit();
            //int result = p.ExitCode;
            //if (inputText.Equals("2") )
            //{
            //    checkDiskSpace(psResponsLines);
            //}
            //AppendOutput("returnval: " + result);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
