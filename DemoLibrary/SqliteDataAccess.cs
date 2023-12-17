using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using Dapper;

namespace DemoLibrary
{
    public class SqliteDataAccess
    {

        public static List<NotitieModel> LaadNotitie() // dit laat een lijst van alle notities zien op het NotitieForm.cs / startscherm
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<NotitieModel>("select * from Notitie", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void NotitieOpslaan(NotitieModel notitie) // dit slaat de notitie op in de database door een nieuwe rij aan te maken en er waarde in te steken
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Notitie (Titel, AanmaakDatum, Inhoud, LaatstBewerkt) values (@Titel, @AanmaakDatum, @Inhoud, @LaatstBewerkt)", notitie);
            }
        }

        public static void BewerkingOpslaan(NotitieModel notitie, string HuidigeNaam) // Stuurt een geupdatete versie van de inhoud, titel en laatstbewerkt naar de sql database. Dit gebeurt adhv de notitie titel
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("UPDATE Notitie SET Titel = @Titel, Inhoud = @Inhoud, LaatstBewerkt = @LaatstBewerkt WHERE Titel = @HuidigeNaam", new { notitie.Titel, notitie.Inhoud, notitie.LaatstBewerkt, HuidigeNaam });
            }
        }

        public static void NotitieVerwijderen(string selected) // notitie verwijderen. Dit doet het adhv de titel van de notitie
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(@"DELETE FROM Notitie WHERE Titel = @Selected", new { Selected = selected });
            }
        }

        public static string LaadInhoud(string selected) // dit is de functie die de inhoud van een notitie laad in het bewerkingsscherm.
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                // vraagt de inhoud via een sql query en zet ze om naar een string. Dit doet ze adhv de titel van de notitie
                string result = cnn.QueryFirstOrDefault<string>(@"SELECT Inhoud FROM Notitie WHERE Titel = @Selected", new { Selected = selected });
                // Resultaat returnen
                return result;
            }
        }

        private static string LoadConnectionString(string id = "Default") // deze functie maakt verbinding met de SQLite database
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
