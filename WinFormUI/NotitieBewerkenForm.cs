using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class NotitieBewerkenForm : Form
    {
        public NotitieBewerkenForm()
        {
            InitializeComponent();
        }

        public void LaadBewerking(string selected) // deze  functie wordt geroepen in de NotitieForm.cs file en zorgt er voor dat alle nodige gegevens in de bewerkings pagina te zien komt
        {
            TitelNotitie.Text = selected; // dit zorgt dat de titel in het veld onder nieuwe titel komt te staan
            InhoudNotitie.Text = SqliteDataAccess.LaadInhoud(selected); // dit is een functie die de inhoud zal inladen
            HuidigeNaam.Text = selected; // dit zorgt er voor dat de huidige titel in de HuidigeTitel label komt te staan
        }


        private void Opslaan_Click(object sender, EventArgs e) // Opslaan knop
        {

            NotitieModel n = new NotitieModel(); // een object maken van de NotitieModel klasse

            string huidigeNaam = HuidigeNaam.Text; // neemt de huidige titel en steekt ze in een variabel
            // zet gegevens in het object
            n.Titel = TitelNotitie.Text;
            n.Inhoud = InhoudNotitie.Text;
            n.LaatstBewerkt = DateTime.Now.ToString("dd/MM/yyyy");

            SqliteDataAccess.BewerkingOpslaan(n, huidigeNaam); // zorgt dat de gegevens worden opgeslagen door ze aan te passen in de SQLite database

            this.Hide(); // verstopt het bewerkingsscherm
            NotitieForm nForm = new NotitieForm(); // maakt een object van de NotitieForm file
            nForm.Show(); // laat het notitieForm scherm zien
        }

        private void Annuleren_Click(object sender, EventArgs e) // annuleren knop --> doet hetzelfde als bij opslaan
        {
            this.Hide();
            NotitieForm nForm = new NotitieForm();
            nForm.Show();
        }
    }
}
