using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        static void leukeFunctie()
        {
            // Dit is een leuke functie
            //Source - https://stackoverflow.com/a
            //Posted by Sorceri, modified by community. See post 'Timeline' for change history
            //2025-11-20, License - CC BY-SA 3.0

            /*
             * Onderstaande gejat van https://stackoverflow.com/questions/45804156/windows-form-textbox-pass-text-value-to-a-powershell-runscript
             * 
            txtUserInfo.Text = RunScript(@"Get-ADUser " + YourTextBox.Text + @" -Properties * |
  Select-Object Enabled, @{Expression={$_.LockedOut};Label='Locked';}, 
    DisplayName, GivenName, SurName, Mail,
    @{ Expression={[DateTime]::FromFileTime($_.LastLogon)}; Label='Last Logon';},
    @{Expression={$_.Created};Label='Date Created';},
    passwordlastset, Passwordneverexpires |
  Format-list");
            */
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
