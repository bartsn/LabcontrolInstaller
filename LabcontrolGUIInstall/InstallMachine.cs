using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    internal class InstallMachine
    {
        private string[] installSteps = {
            "Controle voldoende schrijfruimte.",
            "Controle aanwezigheid git-scm.",
            "Controle aanwezigheid 7-zip.",
            "Aanmaken tijdelijke downloadmap.",
            "Downloaden benodigde installers.",
            "Installeren Python omgeving Labcontrol.",
            "Downloaden en installeren Labcontrol Python scripts.",
            "Installeren VISA omgeving van R&S.",
            "Installeren benodigde Python Packages."
        };      
        public InstallMachine() {
            /*
             * Opstarten:
             *  1. starten van een elevated powershell omgeving of een elevated C# proces.
             *  2. zichtbaar maken Form4b: alles is disabled en checkmarks en pijlen zijn niet zichtbaar.
             * Controle schrijfruimte: stuur een 0 naar het elevated proces.
             */
            int stepCount = installSteps.Length;
            foreach (string step in installSteps)
            {
                Console.WriteLine("Installatiestap: " + step);
                
            }       
        }


    }
}
