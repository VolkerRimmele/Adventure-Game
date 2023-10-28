using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abenteuerspiel_Volker
{
    internal class Boot : Verkehrsmittel
    { 
        int tiefgang;

        public Boot(string marke, int maxGeschwindigkeit, string farbe, int laenge, int anzahlSitze, string beifahrer, int tiefgang)
        {
            Marke = marke;
            MaxGeschwindigkeit = maxGeschwindigkeit;
            Farbe = farbe;
            Laenge = laenge;
            AnzahlSitze = anzahlSitze;
            Beifahrer = beifahrer;
            Tiefgang = tiefgang;
        }
        public int Tiefgang { get => tiefgang; set =>tiefgang = value; }
        public static void Aufruf()
        {
            Boot[] Boote = new Boot[12];//Das Random erzeugte Auto wird später auf Index 11 d.h. auf das 12te Feld gesetzt 
            Console.WriteLine("Sie haben Boot ausgewählt.");
            Console.WriteLine("Stellen Sie nun drei eigene Boote zusammen.");

            for (int i = 0; i < 3; i++)
            {

                //Eingabe Marke
                Console.WriteLine($"Modell {i + 1}:Bitte Marke Eingeben.");
                string marke = Console.ReadLine();
                //Ende Eingabe Marke

                //Eingabe maxGeschwindigkeit
                Console.WriteLine($"Modell {i + 1}:Bitte maxGeschwindigkeit eingeben - Werte von 1 - 10.000.");
                int maxGeschwindigkeit = Convert.ToInt32(Console.ReadLine());//Umwandlung sting in integer Zahl

                while (maxGeschwindigkeit < 1 || maxGeschwindigkeit > 10000)
                {
                    Console.WriteLine($"Modell {i + 1}:Bitte maxGeschwindigkeit eingeben - Werte von 1 - 10.000.");
                    maxGeschwindigkeit = Convert.ToInt32(Console.ReadLine());//Umwandlung sting in integer Zahl
                }
                //Ende Eingabe maxGeschwindigkeit           

                //Eingabe Farbe
                Console.WriteLine($"Modell {i + 1}:Bitte Farbe Eingeben - Die Auswahl ist Rot, Gelb, Blau, Grün, Weiß, Schwarz, Orange.");

                string[] farben = { "Rot", "Gelb", "Blau", "Grün", "Weiß", "Schwarz", "Orange" };
                string farbe = Console.ReadLine();
                bool farbeBool = true;

                while (farbeBool == true)
                {
                    foreach (string einzelfarben in farben)// Jede Farbe in dem Sting-Array farben wird durchlaufen
                    {
                        if (einzelfarben == farbe)//Prüfung ob die jeweilige einzelfarbe des Sting-Array mit der vom user eingebenen farbe übereinstimm
                        {
                            farbeBool = false;//Wenn false war die Eingabe richtig, und die while Schleife wird verlassen. Der zuerst eingelesene Wert bleibt
                        }
                    }
                    if (farbeBool == true) Console.WriteLine($"Modell {i + 1}:Bitte Farbe Eingeben - Die Auswahl ist Rot, Gelb, Blau, Grün, Weiß, Schwarz, Orange.");
                    if (farbeBool == true) farbe = Console.ReadLine();
                }


                //Eingabe Länge
                Console.WriteLine($"Modell {i + 1}:Bitte Länge eingeben - Werte von 1 - 1.000.");
                int laenge = Convert.ToInt32(Console.ReadLine());//Umwandlung String in int Zahl

                while (laenge < 1 || laenge > 1000)
                {
                    Console.WriteLine($"Modell {i + 1}:Bitte Länge eingeben - Werte von 1 - 1.000.");
                    laenge = Convert.ToInt32(Console.ReadLine());//Umwandlung String in int Zahl
                }
                //Ende Eingabe Länge

                //Eingabe Sitze
                Console.WriteLine($"Modell {i + 1}: Bitte Anzahl Sitze eingeben - Werte von 1 - 100.");
                int anzahlSitze = Convert.ToInt32(Console.ReadLine());//Umwandlung String in int Zahl

                while (anzahlSitze < 1 || anzahlSitze > 100)
                {
                    Console.WriteLine($"Modell {i + 1}: Bitte Anzahl Sitze eingeben - Werte von 1 - 100.");
                    anzahlSitze = Convert.ToInt32(Console.ReadLine());//Umwandlung String in int Zahl
                }
                //Ende Eingabe Sitze


                //Eingabe Beifahrer
                Console.WriteLine($"Modell {i + 1}: Bitte Angeben ob mit = (J)a oder ohne = (N)ein Beifahrer.");
                string beifahrer = Console.ReadLine().ToLower();//Macht aus Großbuchstaben Kleinbuchstaben


                string[] beifahrerString = { "J", "Ja", "N", "Nein", "j", "ja", "n", "nein" };//Die Grossbuchstaben hätte ich weglassen können wegen ToLower()
                bool beifahrerBool = true;

                while (beifahrerBool == true)
                {
                    foreach (string einzelbeifahrer in beifahrerString)//Jede vorgegebene Antwortmöglichkeit in dem String-Array befahrerString wird durchlaufen
                    {
                        if (einzelbeifahrer == beifahrer)//Prüfung ob die jeweilige Anwortmöglichkeit (einzelbeifahrer) des String-Arrays mit dem vom user eingebenen beifahrer übereinstimmt
                        {
                            beifahrerBool = false;//Wenn false war die Eingabe richtig, und die while Schleife wird verlassen. Der zuerst eingelesene Wert bleibt
                        }

                    }
                    if (beifahrerBool == true) Console.WriteLine($"Modell {i + 1}: Bitte angeben ob mit = (J)a oder ohne = (N)ein Beifahrer.");
                    if (beifahrerBool == true) beifahrer = Console.ReadLine().ToLower();
                }
                //Ende Eingabe Beifahrer


                //Eingabe Tiefgang des Bootes
                Console.WriteLine($"Modell {i + 1}: Bitte den gewünschten Tiefgang des Bootes angeben - Werte von 1 - 50.");
                int tiefgang = Convert.ToInt32(Console.ReadLine());//Umwandlung String in int Zahl

                while (tiefgang < 1 || tiefgang > 50)
                {
                    Console.WriteLine($"Modell {i + 1}:Bitte den gewünschten Tiefgang des Bootes eingeben - Werte von 1 - 50.");
                    tiefgang = Convert.ToInt32(Console.ReadLine());//Umwandlung String in int Zahl
                }
                //Ende Eingabe Tiefgang des Bootes


                //Aufruf Konstruktor die 3 Boote werden erzeugt. Umwandlung in Eigenschaften
                Boote[i] = new Boot(marke, maxGeschwindigkeit, farbe, laenge, anzahlSitze, beifahrer, tiefgang);
                ////////////////////////Console.WriteLine($"Deine 3 Raumschiffe: {Raumschiffe[i].Marke}, {Raumschiffe[i].MaxGeschwindigkeit}");


            }

            Console.Clear();
            //Ausgabe der gewählten Boote - Index 0-2 d.h. die Boote sollen 1-3 heißen deshalb i+1
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Boote {i + 1}: Marke: {Boote[i].Marke}, MaxGeschw: {Boote[i].MaxGeschwindigkeit}, Farbe: {Boote[i].Farbe}, Länge: {Boote[i].Laenge}, Anzahl Sitze: {Boote[i].AnzahlSitze}, Beifahrer: {Boote[i].Beifahrer}, Tiefgang: {Boote[i].Tiefgang}");
            }


            //Der Computer stellt sich sein eigenes Boot zusammen

            //*Die Marke wird vom Computer erzeugt 5 einzel per Random angwählte Chars werden zusammengefügt zu einem string
            char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            char[] anzahlZeichenMarke = new char[5];//Die Größe des Char-Array wird auf 5 festgelegt
            string anzahlZeichenMarkeString = "";//leerer String wird initialisiert

            Random rand = new Random();//Definition rand - Zur Erzeugung einer Zufallszahl
            for (int i = 0; i < 5; i++)
            {
                int j = rand.Next(0, chars.Length - 1);//Zufallswert j von 0 - (Länge char Array -1) wird erzeugt - entsprechend den Índizes des char Arrays.
                anzahlZeichenMarke[i] = chars[j];//Befüllung des 5-stelligen char Arrays mit den definierten Zufallsbuchstaben - in char[] chars = "ab.." z.B. j=3 ist b"
                anzahlZeichenMarkeString = anzahlZeichenMarkeString + anzahlZeichenMarke[i];//Zeichnenkette wird Stück für Stück verlängert
                //////////////////////Console.WriteLine($"{anzahlZeichenMarke[i]}");
            }
            ////////////////////Console.WriteLine($"{anzahlZeichenMarkeString}");
            //*Ende Die Marke wird vom Computer erzeugt


            //*Die Geschwindigkeit wird vom Computer erzeugt Werte zwischen 1-10000
            Random rand2 = new Random();//Definition rand2 - Zur Erzeugung einer Zufallszahl
            int maxGeschwindingkeitRandom = rand2.Next(1, 10000);
            ////////////////////Console.WriteLine($"{maxGeschwindingkeitRandom}");
            //*Ende die Geschwindingkeit wird vom Computer erzeugt

            //Die Farbe wird vom Computer gewählt
            string[] farbenRandom = { "Rot", "Gelb", "Blau", "Grün", "Weiß", "Schwarz", "Orange" };
            string farbenRandomEnde = "";//leerer String Array wird definiert.
            Random rand3 = new Random();//Definition rand3 - Zur Erzeugung einer Zufallszahl
            int k = rand3.Next(0, farbenRandom.Length - 1);//Eine Zufallszahl zwische 0- (farben lange-1) wird erzeugt: hier 0-6 - entsprechend denIndizes des Array String.
            farbenRandomEnde = farbenRandom[k];//Befüllung mit den entsprechenden Zufallswerten z.B. bei 2 ist es Blau
            ////////////////////Console.WriteLine($"{farbenRandomEnde}");
            //Ende die Farbe wird vom Computer gewählt

            //*Die Länge wird vom Computer erzeugt Werte zwischen 1-1000
            Random rand4 = new Random();//Definition rand4 - Zur Erzeugung einer Zufallszahl
            int maxLaengeRandom = rand4.Next(1, 1000);
            ////////////////////Console.WriteLine($"{maxLaengeRandom}");
            //*Ende die Länge wird vom Computer erzeugt

            //*Die Anzahl Sitze wird vom Computer erzeugt Werte zwischen 1-100
            Random rand5 = new Random();//Definition rand5 - Zur Erzeugung einer Zufallszahl
            int maxSitzeRandom = rand5.Next(1, 100);
            ////////////////////Console.WriteLine($"{maxSitzeRandom}");
            //*Ende die Anzahl Sitze wird vom Computer erzeugt


            //*Beifahrer wird vom Computer erzeugt
            string[] beifahrerRandom = { "j", "n", "ja", "nein" };//Definition String-Array
            string beifahrerRandomEnde = "";//Definition leerer String
            Random rand6 = new Random();//Definition rand6 - Zur Erzeugung einer Zufallszahl
            int l = rand6.Next(0, beifahrerRandom.Length - 1);//Zufallswert 0-3 wird erzeugt, entsprechend den Indizes beifahrerRandom-Array
            beifahrerRandomEnde = beifahrerRandom[l];//Befüllung mit den entsprechenden Zufallswerten z.B. 2="ja"
            ////////////////////Console.WriteLine($"{beifahrerRandomEnde}");                 
            //*Beifahrer Ja/Nein wird vom Computer erzeugt

            //*Der Tiefgang wird vom Computer erzeugt Werte zwischen 1-50
            Random rand7 = new Random();//Definition rand6 - Zur Erzeugung einer Zufallszahl
            int tiefgangRandom = rand7.Next(1, 50);
            ////////////////////Console.WriteLine($"{tiefgangRandom}");
            //*Ende der die Tiefgang wird vom Computer erzeugt


            //Der Computer hat folgendes Boot per Random erzeugt. // Der Konstruktor wird wieder aufgerufen und das Boot erzeugt. Umwandlung in Eigenschaften
            Boote[11] = new Boot(anzahlZeichenMarkeString, maxGeschwindingkeitRandom, farbenRandomEnde, maxLaengeRandom, maxSitzeRandom, beifahrerRandomEnde, tiefgangRandom);
            //Ende Der Computer hat folgendes Boot per Random erzeugt.;

            Console.WriteLine($"\nDer Computer spielt mit folgendem Boot : Marke: {Boote[11].Marke}, MaxGeschw: {Boote[11].MaxGeschwindigkeit}, Farbe: {Boote[11].Farbe}, Länge: {Boote[11].Laenge}, Anzahl Sitze: {Boote[11].AnzahlSitze}, Beifahrer: {Boote[11].Beifahrer}, Tiefgang: {Boote[11].Tiefgang}\n");


            //Der Computer wählt per Zufall 3 Fragen aus 10 vorgegebenen Fragen aus
            //
            //Das Array anzahlFragen wird mit 1-10 gefüllt
            int[] anzahlFragen = new int[10]; // Definition eines 10-stelligen Arrays. Hier wurde tatsächlich nur die Länge verwendet

            Random rnd = new Random();//Definition - Zur Erzeugung einer Zufallszahl
            int[] gezogeneFrage = new int[3];//das Array für die gezogenen Zahlen wird definiert. Hier sollen 3 Werte aus dem Bereich 1-10 stehen

            //Drei Frage sollen aus 10 möglichen Fragen gezogen werden
            for (int i = 0; i < 3; i++)
            {
                bool doppeltFragen = false;
                do
                {
                    gezogeneFrage[i] = rnd.Next(1, anzahlFragen.Length);//Der 3-stellig Array wird mit zufälligen Werten von 1-10 gefüllt 
                    doppeltFragen = false;

                    for (int j = 0; j < i; j++)
                    {
                        if (i > 0 && (gezogeneFrage[i] == gezogeneFrage[j]))//Schleife nur zur Überprüfung auf doppelte
                                                                            //Die aktuelle gezogene Frage wird mit allen vorher gezogenen Fragen verglichen.    
                                                                            //Bei Gleichheit wir neu gezogen. i wird erst erhöht wenn keine Gleichheit mit den vorherigen
                                                                            //Fragen vorhanden ist - doppeltFragen ist dann false und i wird erhöht
                        {
                            doppeltFragen = true;
                        }
                    }

                } while (doppeltFragen == true);

            }
            //Ende drei Fragen sollen aus 10 möglichen Fragen gezogen werden


            //Liste von Frage die der Computer erstellt hat. 
            for (int i = 0; i < 3; i++)
            {
                if (gezogeneFrage[i] == 1) Console.WriteLine($"Frage 1: Sie müssen über das riesige Meer fahren, hohe Wellen.");
                if (gezogeneFrage[i] == 2) Console.WriteLine($"Frage 2: Riesige große Meeresungeheuer warten auf Sie.");
                if (gezogeneFrage[i] == 3) Console.WriteLine($"Frage 3: Ein Passage durch einen flachen Fluss erwartet Sie.");
                if (gezogeneFrage[i] == 4) Console.WriteLine($"Frage 4: Wilde Fische reagieren auf dunkle Farben allergisch.");
                if (gezogeneFrage[i] == 5) Console.WriteLine($"Frage 5: Die Marken mit Anfangsbuchstaben a bzw. A sind an Ihrem Zielort verhasst.");
                if (gezogeneFrage[i] == 6) Console.WriteLine($"Frage 6: Die Bewohner an Ihrem Zielort mögen keine protzig aussehenden Boote.");
                if (gezogeneFrage[i] == 7) Console.WriteLine($"Frage 7: Die Fahrt zum Zielort dauert sehr lange, Sie könnten verdursten.");
                if (gezogeneFrage[i] == 8) Console.WriteLine($"Frage 8: Ein Beifahrer fehlt Ihnen.");
                if (gezogeneFrage[i] == 9) Console.WriteLine($"Frage 9: Sie müssen zwischendurch anhalten und viele Leute mitnehmen, sie werden Ihnen helfen.");
                if (gezogeneFrage[i] == 10) Console.WriteLine($"Frage 10: Die Reise ist schön, Sie wollen sie genießen, alles ist vorrätig.");

            }

            Console.WriteLine($"\nSie kennen jetzt das Boot gegen das Sie spielen werden und wissen jetzt auch auf was es ankommt, wählen Sie nun ihr Boot aus (1,2 oder 3).");

            int auswahlBoot = Convert.ToInt32(Console.ReadLine());

            //while (auswahlRaumschiff < 1 || auswahlRaumschiff > 3)
            //{
            //    Console.WriteLine($"\nHallo User: Du kennst jetzt das Raumschiff gegen das du Spielen wirst und du weiß jetzt auch auf was es ankommt, Wähle nun Dein Raumschiff auf (1,2 oder 3) ");
            //    auswahlRaumschiff = Convert.ToInt32(Console.ReadLine());
            //}


            Fragenblock(auswahlBoot);//Methodenaufruf zu void Fragenblock. Die Zeile darunter


            void Fragenblock(int auswahlBoot)
            {
                int i = auswahlBoot;// i repräsentiert das von uns ausgewählte Boot // auswahlBoot geht von 1-3 damit es zum Index 0-2 passt auswahBoot-1
                int gewinnpunkte = 0;
                Console.WriteLine($"\nHallo User, Boot   Nr. {i} wurde gewählt\n");
                ////Console.Clear();

                for (int j = 0; j < 3; j++)// j sind die 3 gezogenen Fragen aus dem Bereich der 10 Fragen
                {
                    if (gezogeneFrage[j] == 1)
                    {
                        Console.WriteLine($"Frage 1: Sie müssen über das riesige Meer fahren, hohe Wellen - Eine großer Tiefgang ist wichtig.");
                        if (Boote[11].Tiefgang <= Boote[auswahlBoot - 1].Tiefgang)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }
                    }
                    else if (gezogeneFrage[j] == 2)
                    {
                        Console.WriteLine($"Frage 2: Riesige große Meeresungeheuer warten auf Sie - Das Boot sollte möglichst groß sein.");
                        if (Boote[11].Laenge <= Boote[auswahlBoot - 1].Laenge)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }
                    }
                    else if (gezogeneFrage[j] == 3)
                    {
                        Console.WriteLine($"Frage 3: Ein Passage durch einen flache Fluss erwartet Sie - Wenig Tiefgang ist gefragt.");
                        if (Boote[11].Tiefgang >= Boote[auswahlBoot - 1].Tiefgang)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }
                    }
                    else if (gezogeneFrage[j] == 4)
                    {
                        Console.WriteLine($"Frage 4: Wilde Fische reagieren auf dunkle Farben allergisch - Sie gewinnen wenn Ihr Boot Weiß oder Gelb ist.");
                        if (Boote[auswahlBoot -1].Farbe == "Weiß" || Boote[auswahlBoot - 1].Farbe == "Gelb")
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }
                    }
                    else if (gezogeneFrage[j] == 5)
                    {
                        Console.WriteLine($"Frage 5: Die Marken mit Anfangsbuchstaben a bzw. A sind an Ihrem Zielort verhasst - Sie gewinnen wenn eigene Marke nicht A... oder a... ist.");
                        if (Boote[auswahlBoot - 1].Marke[0] == 'a' || Boote[auswahlBoot - 1].Marke[0] == 'A')
                        {
                            gewinnpunkte = gewinnpunkte + 0;
                        }
                        else
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                        }
                    }
                    else if (gezogeneFrage[j] == 6)
                    {
                        Console.WriteLine($"Frage 6: Die Bewohner an Ihrem Zielort mögen keine protzig aussehenden Boote - Länge und Tiefgang sollten klein sein.");
                        if ((Boote[11].Laenge >= Boote[auswahlBoot - 1].Laenge) && (Boote[11].Tiefgang >= Boote[auswahlBoot - 1].Tiefgang))
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }

                    }
                    else if (gezogeneFrage[j] == 7)
                    {
                        Console.WriteLine($"Frage 7: Die Fahrt zum Zielort dauert sehr lange, Sie könnten verdursten - Die Geschwindigkeit sollte hoch sein.");
                        if (Boote[11].MaxGeschwindigkeit <= Boote[auswahlBoot - 1].MaxGeschwindigkeit)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }

                    }
                    else if (gezogeneFrage[j] == 8)
                    {
                        Console.WriteLine($"Frage 8: Ihr Beifahrer hilft Ihnen - Der, der keinen Beifahrer hat, verliert.");
                        if (Boote[auswahlBoot - 1].Beifahrer == "ja" || Boote[auswahlBoot - 1].Beifahrer == "j")
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }

                    }
                    else if (gezogeneFrage[j] == 9)
                    {
                        Console.WriteLine($"Frage 9: Sie müssen zwischendurch anhalten und viele Leute mitnehmen, sie werden Ihnen helfen.");
                        if (Boote[11].AnzahlSitze <= Boote[auswahlBoot - 1].AnzahlSitze)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }

                    }
                    else if (gezogeneFrage[j] == 10)
                    {
                        Console.WriteLine($"Frage 10: Die Reise ist schön, Sie wollen sie genießen, alles ist vorrätig - Der langsamste gewinnt.");
                        if (Boote[11].MaxGeschwindigkeit >= Boote[auswahlBoot - 1].MaxGeschwindigkeit)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Irgendwas ging hier schief.");
                    }


                }
                Console.WriteLine($"\nGewinnpunkte: {gewinnpunkte}");
                if (gewinnpunkte == 0)
                {
                    Console.WriteLine($"O Punkte, dass war nichts leider verloren."); 
                }
                else if (gewinnpunkte == 1)
                {
                    Console.WriteLine($"1 Punkt, reicht leider nicht für den Ernstfall.");
                }
                else if (gewinnpunkte == 2)
                {
                    Console.WriteLine($"2 Punkte, gute Leistung.");
                }
                else if (gewinnpunkte == 3)
                {
                    Console.WriteLine($"3 Punkte, besser geht es nicht.");
                }
                else
                {
                    Console.WriteLine("Irgendwas ging hier schief.");
                }

                //Ende
                //Ende ohne Endemenue


                do
                {
                    Console.WriteLine($"\nBesteht der Wunsch Ihr Ergebnis zu verbessen? - Bitte (J)a oder (N)ein eingeben.");
                    string endRunde = Console.ReadLine().ToLower();
                    if (endRunde == "ja" || endRunde == "j")
                    {
                        User.EndeFunktion(gewinnpunkte);//Methodenaufruf -> EndeFunktion(int punkte) in user.cs - Gewinnpunkte werden übergeben
                        break;
                    }
                    else if (endRunde == "nein" || endRunde == "n")
                    {
                        Console.WriteLine($"\nBitte unbedingt auch die Rettung per Boot und Auto spielen.");
                        do
                        {
                            Console.WriteLine("\nNeues Spiel beginnnen? J(a) oder (N)ein.");
                            string endRunde4 = Console.ReadLine().ToLower();
                            if (endRunde4 == "ja" || endRunde4 == "j")
                            {
                                User.Menue();
                                break;
                            }
                            else if (endRunde4 == "nein" || endRunde4 == "n")
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine($"\nUngültige Eingabe - Bitte (J)a oder (N)ein eingeben.");
                            }
                        } while (true);
                    }
                    else
                    {
                        Console.WriteLine($"\nUngültige Eingabe - Bitte (J)a oder (N)ein eingeben.");
                    }
                } while (true);

            }//Void Fragenblock ist Zuende

        }

    }


}
