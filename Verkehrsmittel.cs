using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abenteuerspiel_Volker
{
    //Abstrakte Klasse ohne Objekte - nur zum Vererben erstellt. Auto Boot und Raumschiff.cs erben
    abstract class Verkehrsmittel
    {
        string marke;
        int maxGeschwindigkeit;
        string farbe;
        int laenge;
        int anzahlSitze;
        string beifahrer;

 
        public string Marke { get => marke; set => marke = value; }
        public int MaxGeschwindigkeit { get => maxGeschwindigkeit; set => maxGeschwindigkeit = value; }
        public string Farbe { get => farbe; set => farbe = value; }
        public int Laenge { get => laenge; set => laenge = value; }
        public int AnzahlSitze { get => anzahlSitze; set => anzahlSitze = value; }
        public string Beifahrer { get => beifahrer; set => beifahrer = value; }

        //public static void Anmeldung()
        //{
        //    Console.WriteLine("Anmeldung1");
        //}

    }
}
