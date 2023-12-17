using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class NotitieModel
    {
        public string Titel { get; set; } // dit is voor de titel van de notitie
        public string AanmaakDatum { get; set; } // dit is voor de aanmaakdatum van de notitie
        public string LaatstBewerkt { get; set; } // dit is voor de laatste bewerking van de notitie bij te houden
        public string Inhoud { get; set; } // dit is voor de inhoud van de notitie

    }
}
