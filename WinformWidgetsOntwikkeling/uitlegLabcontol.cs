using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class uitlegLabcontol : Form
    {
        private String uitleg = "Deze installer doorloopt de volgende stappen:\r\n\r\n" +
            "1. Aanmaken van c:\\temp. Dit is een tijdelijke werkmap, nodig voor het downloaden en uitpakken van bestanden\r\n" +
            "2. Controleren of de computer voorzien is van git. Als dit niet het geval is wordt git-scm gedownload en wordt de installer gestart.\r\n" +
            "3. Controle van de aanwezigheid van 7-Zip. Indien niet aanwezig, zorgt de installer voor downloaden en istallatie van dit pakket.\r\n" +
            "4. Downloaden en installeren van WinPython. Nadat WinPython installatie, hernoemt deze installer de WinPython map naar c:\\Labcontrol.\r\n" +
            "5. Download en installeren van de labcontrol Python scripts\r\n" +
            "6. Installeren van een VISA omgeving. Installatie van een VISA is noodzakelijk omdat het de drivers bevat voor de aansturinig van de meetapparatuur";
        
        private void setUitlegText()
        {
            this.uitlegTextBox.Text = uitleg;
        }
        public uitlegLabcontol()
        {
            InitializeComponent();
            setUitlegText();
            new Form2().Visible=true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
