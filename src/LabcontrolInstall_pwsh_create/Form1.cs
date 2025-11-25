using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LabcontrolInstall
{
    public partial class Form1 : Form
    {
        private String myScriptFileName = "C:\\github\\LabcontrolInstaller\\src\\LabcontrolInstall\\LabcontrolInstaller.ps1";
        public Form1()
        {
            InitializeComponent();
        }

        public void setScriptFileName(String fileName)
        {
            this.myScriptFileName = @fileName; 
        }
        // UI-safe append
        private void AppendOutput(string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<string>(AppendOutput), text);
            }
            else
            {
                richOutBox.AppendText(text + Environment.NewLine);
            }
        }
        private async void button1_Click(object sender, EventArgs e)
        {
           
            
            using (PowerShell ps = PowerShell.Create())
            {
                //ps.AddScript(@"C:\github\LabcontrolInstaller\src\LabcontrolInstall\testscript.ps1");
                ps.AddScript(this.myScriptFileName);
                // STREAM HANDLERS
                ps.Streams.Information.DataAdded += (s, args) =>
                {
                    var record = ps.Streams.Information[args.Index];
                    AppendOutput($"[HOST] {record.MessageData}");
                };

                ps.Streams.Error.DataAdded += (s, args) =>
                {
                    var record = ps.Streams.Error[args.Index];
                    AppendOutput($"[ERROR] {record.ToString()}");
                };

                ps.Streams.Warning.DataAdded += (s, args) =>
                {
                    var record = ps.Streams.Warning[args.Index];
                    AppendOutput($"[WARNING] {record.Message}");
                };

                ps.Streams.Debug.DataAdded += (s, args) =>
                {
                    var record = ps.Streams.Debug[args.Index];
                    AppendOutput($"[DEBUG] {record.Message}");
                };

                ps.Streams.Verbose.DataAdded += (s, args) =>
                {
                    var record = ps.Streams.Verbose[args.Index];
                    AppendOutput($"[VERBOSE] {record.Message}");
                };

                // NORMAL OUTPUT
                var output = await Task.Run(() => ps.Invoke());

                foreach (var item in output)
                {
                    AppendOutput(item.ToString());
                }
            }

        }// End pipeline shit.
    }
}
