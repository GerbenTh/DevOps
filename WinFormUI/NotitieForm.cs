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
    public partial class NotitieForm : Form
    {
        List<NotitieModel> notitie = new List<NotitieModel>();

        public NotitieForm()
        {
            InitializeComponent();

            LaadNotitieLijst();
        }

        private void LaadNotitieLijst() // dit laat alle gemaakte notities zien
        { 
            notitie = SqliteDataAccess.LaadNotitie();

            WireUpNotitieLijst();
        }

        private void WireUpNotitieLijst() // dit laat de titel column van de gemaakte rijen in de database zien.
        {
            LijstAlleNotities.DataSource = null;
            LijstAlleNotities.DataSource = notitie;
            LijstAlleNotities.DisplayMember = "Titel";
        }

        private void LijstHerladen_Click(object sender, EventArgs e) // lijst herladen knop
        {
            LaadNotitieLijst(); // functie om de lijst met notities te laden
        }

        private void NotitieToevoegen_Click(object sender, EventArgs e) // notitie toevoegen knop
        {
            NotitieModel n = new NotitieModel(); // maakt een object aan van NotitieModel
            // geeft waarde aan de attributen van het object
            n.Titel = TitelText.Text; 
            n.AanmaakDatum = DateTime.Now.ToString("dd/MM/yyyy");
            n.Inhoud = "";
            n.LaatstBewerkt = DateTime.Now.ToString("dd/MM/yyyy");

            SqliteDataAccess.NotitieOpslaan(n); // zet het object in de SQLite database

            TitelText.Text = ""; // maakt het tekstvak voor de titel terug leeg
        }

        private void Bewerken_Click(object sender, EventArgs e) // bewerken knop
        {
            string selected = LijstAlleNotities.GetItemText(LijstAlleNotities.SelectedValue);

            this.Hide(); // verstopt het overzicht scherm
            NotitieBewerkenForm bewerken = new NotitieBewerkenForm(); // dit maakt een object van de klasse NotitieBewerkenForm aan
            bewerken.LaadBewerking(selected); // een functie van het object bewerken. De functie zorgt dat de naam op het bewerken scherm te zien komt
            bewerken.Show(); // laat het bewerken scherm zien

        }

        private void Verwijderen_Click(object sender, EventArgs e) // verwijderen knop
        {
            string selected = LijstAlleNotities.GetItemText(LijstAlleNotities.SelectedValue);

            SqliteDataAccess.NotitieVerwijderen(selected); // verwijderd de geselecteerde notitie

        }
    }
}
