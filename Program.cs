using System.Diagnostics.Metrics;
using System.Net.Mail;
using System.Runtime.Intrinsics.X86;

namespace Abenteuerspiel_Volker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User.Start();
            //0. Anmeldung mit Passwort Überprüfung
            //1. Der Spieler hat ich im Wald verirrt und kann aussuchen ob er sich von einem Raumschiff oder Auto oder Schiff retten lassen will
            //2. Der Spieler gibt dann je nach Auswahl 3 Raumschiffe oder Autos oder Boote ein
            //3. Der Computer erzeugt per Random ein eigenes Raumschiff oder Auto oder Boot - entsprechend dem was der User gewählt hat
            //4. Der Computer sucht sich per Random 3 Fragen aus 10 vorgefertigten Fragen aus.
            //5. Alles ist am Bildschirm zu sehen. Also z.B. die erzeugten Raumschiffe, das Random Raumschiff des Computer und die 3 zugehörigen Fragen
            //6. Der Spieler entschiedet anhand der Fragen und des Random Verkehrsmittels des Computers mit welchem seiner 3 Verkehrsmittel er gegen den Computer antreten will
            //7. Der Computer gleicht anhand jeder einzelnen Fragen ab, wer gewonnen hat. Es gibt also maximal 3 Punkte. Minimal 0 Punkte
            //8. Danach wird der User gefragt ob er sein Ergebnis verbessern will. Bei nein kommt er je nach Wunsch wieder ins Menue oder verlässt das Programm.
            //bei ja folgen noch weitere Fragen die in Verschiedene Zweige münden.

        }
    
    }
}               