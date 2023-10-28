using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abenteuerspiel_Volker
{
    internal class Raumschiff : Verkehrsmittel
    {
        int spannweite;
        
        public Raumschiff(string marke, int maxGeschwindigkeit, string farbe, int laenge, int anzahlSitze, string beifahrer, int spannweite)
        {
            Marke = marke;
            MaxGeschwindigkeit = maxGeschwindigkeit;
            Farbe = farbe;
            Laenge = laenge;
            AnzahlSitze = anzahlSitze;
            Beifahrer = beifahrer;
            Spannweite = spannweite;
        }
//
//      public static object Raumschiffe { get; private set; }
        public int Spannweite { get => spannweite; set => spannweite = value; }

        //Raumschiff[] Raumschiffe = new Raumschiff[3];
        public static void Aufruf()
        {
            Raumschiff[] Raumschiffe = new Raumschiff[12];//Das Random erzeugte Raumschiff wird später auf Index 11 d.h. auf das 12te Feld gesetzt 
            Console.WriteLine("Sie haben Raumschiff ausgewählt.");
            Console.WriteLine("Stellen Sie nun drei eigene Raumschiffe zusammen.");

            for (int i = 0; i < 3; i++)
            {

                //Eingabe Marke
                Console.WriteLine($"Modell {i + 1}:Bitte Marke Eingeben");
                string marke = Console.ReadLine();
                //Ende Eingabe Marke

                //Eingabe maxGeschwindigkeit
                Console.WriteLine($"Modell {i + 1}:Bitte maxGeschwindigkeit eingeben Werte von 1 - 10.000.");
                int maxGeschwindigkeit = Convert.ToInt32(Console.ReadLine());//Umwandlung sting in integer Zahl
                //Ende Eingabe maxGeschwindigkeit

                while (maxGeschwindigkeit < 1 || maxGeschwindigkeit > 10000)
                {
                    Console.WriteLine($"Modell {i + 1}:Bitte maxGeschwindigkeit eingeben Werte von 1 - 10.000.");
                    maxGeschwindigkeit = Convert.ToInt32(Console.ReadLine());//Umwandlung sting in integer Zahl
                }
                //Ende Eingabe maxGeschwindigkeit           

                //Eingabe Farbe
                Console.WriteLine($"Modell {i + 1}:Bitte Farbe Eingeben - Die Auswahl ist Rot, Gelb, Blau, Grün, Weiß, Schwarz, Orange.");

                string[] farben = {"Rot", "Gelb", "Blau", "Grün", "Weiß", "Schwarz", "Orange"};
                string farbe = Console.ReadLine();
                bool farbeBool = true;
                
                while (farbeBool == true)
                {
                    foreach (string einzelfarben in farben)// Jede Farbe in dem Sting-Array farben wird durchlaufen
                    {
                        if (einzelfarben == farbe)//Prüfung ob die jeweilige einzelfarbe des Sting-Array mit der vom user eingebenen farbe übereinstimmt 
                        {
                            farbeBool = false;//Wenn false war die Eingabe richtig, und die while Schleife wird verlassen. Der zuerst eingelesene Wert bleibt
                        }

                    }
                    if (farbeBool == true) Console.WriteLine($"Modell {i + 1}:Bitte Farbe Eingeben - Die Auswahl ist Rot, Gelb, Blau, Grün, Weiß, Schwarz, Orange.");
                    if (farbeBool == true) farbe = Console.ReadLine();
                }
                //Ende Eingabe Farbe

                //Eingabe Länge
                Console.WriteLine($"Modell {i+1}:Bitte Länge eingeben - Werte von 1 - 1.000.");
                int laenge = Convert.ToInt32(Console.ReadLine());//Umwandlung sting in integer Zahl

                while (laenge < 1 || laenge > 1000)
                {
                    Console.WriteLine($"Modell {i + 1}:Bitte Länge eingeben - Werte von 1 - 1.000.");
                    laenge = Convert.ToInt32(Console.ReadLine());//Umwandlung sting in integer Zahl
                }
                //Ende Eingabe Länge

                //Eingabe Sitze
                Console.WriteLine($"Modell {i+1}: Bitte Anzahl Sitze eingeben - Werte von 1 - 100."); 
                int anzahlSitze = Convert.ToInt32(Console.ReadLine());//Umwandlung sting in integer Zahl

                while (anzahlSitze < 1 || anzahlSitze > 100)
                {
                    Console.WriteLine($"Modell {i + 1}: Bitte Anzahl Sitze eingeben - Werte von 1 - 100.");
                    anzahlSitze = Convert.ToInt32(Console.ReadLine());//Umwandlung sting in integer Zahl
                }
                //Ende Eingabe Sitze


                //Eingabe Beifahrer
                 Console.WriteLine($"Modell {i + 1}: Bitte Angeben ob mit = (J)a oder ohne = (N)ein Beifahrer.");
                 string beifahrer = Console.ReadLine().ToLower();//Macht aus Großbuchstaben Kleinbuchstaben
  

                string[] beifahrerString = { "J", "Ja", "N", "Nein", "j", "ja", "n", "nein"};//Die Grossbuchstaben hätte ich weglassen können wegen ToLower()
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
                    if (beifahrerBool == true) Console.WriteLine($"Modell {i + 1}: Bitte Angeben ob mit = (J)a oder ohne = (N)ein Beifahrer.");
                    if (beifahrerBool == true) beifahrer = Console.ReadLine().ToLower();
                }
                //Ende Eingabe Beifahrer


                //Eingabe Spannweite
                Console.WriteLine($"Modell {i + 1}: Bitte die gewünsche Spannweite des Raumschiffs angeben - Werte von 1 - 1000.");
                int spannweite = Convert.ToInt32(Console.ReadLine());//Umwandlung sting in integer Zahl

                while (spannweite < 1 || spannweite > 1000)
                {
                    Console.WriteLine($"Modell {i + 1}:Bitte die gewünschte Spannweite des Raumschiffs eingeben - Werte von 1 - 1000.");
                    spannweite = Convert.ToInt32(Console.ReadLine());//Umwandlung sting in integer Zahl
                }
                //Ende Eingabe Spannweite


                //Aufruf Konstruktor die 3 Raumschiffe werden erzeugt. Umwandlung in Eigenschaften
                Raumschiffe[i] = new Raumschiff(marke, maxGeschwindigkeit, farbe, laenge, anzahlSitze, beifahrer, spannweite);
                ////////////////////////Console.WriteLine($"Deine 3 Raumschiffe: {Raumschiffe[i].Marke}, {Raumschiffe[i].MaxGeschwindigkeit}");


            }

            Console.Clear();
            //Ausgabe der gewählten Raumschife - Index 0-2 d.h. die Boote sollen 1-3 heißen deshalb i+1
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Raumschiffe {i+1}: Marke: {Raumschiffe[i].Marke}, MaxGeschw: {Raumschiffe[i].MaxGeschwindigkeit}, Farbe: {Raumschiffe[i].Farbe}, Länge: {Raumschiffe[i].Laenge}, Anzahl Sitze: {Raumschiffe[i].AnzahlSitze}, Beifahrer: {Raumschiffe[i].Beifahrer}, Spannweite: {Raumschiffe[i].Spannweite}");
            }


            //Der Computer stellt sich sein eigenes Raumschiff zusammen

            //*Die Marke wird vom Computer erzeugt 5 einzel per Random angwählte Chars werden zusammengefügt zu einem string
            char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            char [] anzahlZeichenMarke = new char[5];//Die Größe des Char-Array wird auf 5 festgelegt
            string anzahlZeichenMarkeString = "";//leerer String wird initialisiert

            Random rand = new Random();//Definition rand - Zur Erzeugung einer Zufallsza
            for (int i = 0; i < 5; i++)
            { 
                int j = rand.Next(0, chars.Length-1);//Zufallswert j von 0 - (Länge char Array -1) wird erzeugt - entsprechend den Indizes des char Arrays
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
            string farbenRandomEnde = ""; ;//leerer String Array wird definiert.
            Random rand3 = new Random();//Definition rand3 - Zur Erzeugung einer Zufallszahl
            int k = rand3.Next(0, farbenRandom.Length-1);//Eine Zufallszahl zwische 0- (farben lange-1) wird erzeugt: hier 0-6 - entsprechend denIndizes des Array String
            farbenRandomEnde = farbenRandom[k]; ;//Befüllung mit den entsprechenden Zufallswerten z.B. bei 2 ist es Blau
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


            //*Beifahrer wird vom Computer erzeugt Werte zwischen ja, 2=nein
            string[] beifahrerRandom = { "j", "n","ja","nein"};//Definition String-Array
            string beifahrerRandomEnde = "";//Definition leerer String
            Random rand6 = new Random();//Definition rand6 - Zur Erzeugung einer Zufallszahl
            int l = rand6.Next(0, beifahrerRandom.Length - 1);//Zufallswert 0-3 wird erzeugt, entsprechend den Indizes beifahrerRandom-Array
            beifahrerRandomEnde = beifahrerRandom[l];//Befüllung mit den entsprechenden Zufallswerten z.B. 2="ja"
            ////////////////////Console.WriteLine($"{beifahrerRandomEnde}");                 
            //*Beifahrer Ja/Nein wird vom Computer erzeugt

            //*Spannweite wird vom Computer erzeugt Werte zwischen 1-1000
            Random rand7 = new Random();//Zur Erzeugung einer Zufallszahl
            int spannweiteRandom = rand7.Next(1, 1000);
            ////////////////////Console.WriteLine($"{spannweiteRandom}");
            //*Ende die Spannweite wird vom Computer erzeugt


            //Der Computer hat folgendes Raumschiff per Random erzeugt. // Der Konstruktor wird wieder aufgerufen und das Raumschiff erzeugt. Umwandlung in Eigenschaften
            Raumschiffe[11] = new Raumschiff(anzahlZeichenMarkeString, maxGeschwindingkeitRandom, farbenRandomEnde, maxLaengeRandom, maxSitzeRandom, beifahrerRandomEnde, spannweiteRandom);
            //Der Computer hat folgendes Raumschiff per Random erzeugt.;

            Console.WriteLine($"\nDer Computer spielt mit folgendem Raumschiff : Marke: {Raumschiffe[11].Marke}, MaxGeschw: {Raumschiffe[11].MaxGeschwindigkeit}, Farbe: {Raumschiffe[11].Farbe}, Länge: {Raumschiffe[11].Laenge}, Anzahl Sitze: {Raumschiffe[11].AnzahlSitze}, Beifahrer: {Raumschiffe[11].Beifahrer}, Spannweite: {Raumschiffe[11].Spannweite}\n");


            //Der Computer wählt per Zufall 3 Fragen aus 10 vorgegebenen Fragen aus
            //
            //Das Array anzahlFrage wird mit 1-10 gefüllt
            int[] anzahlFragen = new int[10]; // Definition eines 10-stelligen Arrays. Hier wurde tatsächlich nur die Länge verwendet

            Random rnd = new Random();//Definition - Zur Erzeugung einer Zufallszahl
            int[] gezogeneFrage = new int[3];//das Array für die gezogenen Zahlen. Hier sollen 3 Werte aus dem Bereich 1-10 stehen

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
                                                                            //Fragen vorhanden ist - doppeltFragen ist dann false und i wird erhöht.
                        {
                            doppeltFragen = true;
                        }
                    }

                } while (doppeltFragen == true);

            }
            //Drei Fragen sollen aus 10 möglichen Fragen gezogen werden

            //Liste von Fragen die der Computer erstellt hat. 
            for (int i = 0; i < 3; i++)
            {
                if (gezogeneFrage[i] == 1) Console.WriteLine($"Frage 1: Sie müssen über das riesige Gebirge fliegen, unwegsames Gelände.");
                if (gezogeneFrage[i] == 2) Console.WriteLine($"Frage 2: Riesige große Vögel warten im Weltraum auf Sie.");
                if (gezogeneFrage[i] == 3) Console.WriteLine($"Frage 3: Tanken könnte schwierig werden, die Fähigkeit zum Segelfliegen wäre jetzt gut.");
                if (gezogeneFrage[i] == 4) Console.WriteLine($"Frage 4: Wilde Tiere reagieren auf helle Farben allergisch.");
                if (gezogeneFrage[i] == 5) Console.WriteLine($"Frage 5: Die Marken mit Anfangsbuchstaben a bzw. A sind an Ihrem Zielort verhasst.");
                if (gezogeneFrage[i] == 6) Console.WriteLine($"Frage 6: Die Bewohner an Ihrem Zielort mögen keine protzig aussehenden Raumschiffe.");
                if (gezogeneFrage[i] == 7) Console.WriteLine($"Frage 7: Die Fahrt zum Zielort dauert sehr lange, Sie könnten verdursten.");
                if (gezogeneFrage[i] == 8) Console.WriteLine($"Frage 8: Ihr Beifahrer mach Ärger.");
                if (gezogeneFrage[i] == 9) Console.WriteLine($"Frage 9: Sie müssen zwischendurch anhalten und viele Leute mitnehmen, sie werden Ihnen helfen.");
                if (gezogeneFrage[i] == 10) Console.WriteLine($"Frage 10: Die Reise ist schön, Sie wollen sie genießen, alles ist vorrätig.");

            }
            
            Console.WriteLine($"\nSie kennen jetzt das Raumschiff gegen das Sie spielen werden, und die Fragen, wählen Sie nun Ihr Raumschiff aus (1,2 oder 3).");
            
            int auswahlRaumschiff = Convert.ToInt32(Console.ReadLine());

            //while (auswahlRaumschiff < 1 || auswahlRaumschiff > 3)
            //{
            //    Console.WriteLine($"\nHallo User: Du kennst jetzt das Raumschiff gegen das du Spielen wirst und du weiß jetzt auch auf was es ankommt, Wähle nun Dein Raumschiff auf (1,2 oder 3) ");
            //    auswahlRaumschiff = Convert.ToInt32(Console.ReadLine());
            //}


            Fragenblock(auswahlRaumschiff);//Methodenaufruf zu void Fragenblock. Die Zeile darunte


            void Fragenblock(int auswahlRaumschiff)
            {
                int i = auswahlRaumschiff;// i repräsentiert das von uns ausgewählte Raumschiff // auswahlRaumschiff geht von 1-3 damit es zum Index 0-2 passt auswahlRaumschiff-1
                int gewinnpunkte = 0;
                Console.WriteLine($"\nHallo User, Raumschiff Nr. {i} wurde gewählt\n");
                ////Console.Clear();

                for (int j = 0; j < 3; j++)// j sind die 3 gezogenen Fragen aus dem Bereich der 10 Fragen
                {
                    if (gezogeneFrage[j] == 1)
                    {
                        Console.WriteLine($"Frage 1: Sie müssen über das riesige Gebirge fliegen, unwegsames Gelände - Die Spannweite sollte klein sein.");
                        if (Raumschiffe[11].Spannweite >= Raumschiffe[auswahlRaumschiff - 1].Spannweite)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }
                    }
                    else if (gezogeneFrage[j] == 2)
                    {
                        Console.WriteLine($"Frage 2: Riesige große Vögel warten im Weltraum auf Sie - Das Raumschiff sollte möglichst lang sein.");
                        if (Raumschiffe[11].Laenge <= Raumschiffe[auswahlRaumschiff - 1].Laenge)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }
                    }
                    else if (gezogeneFrage[j] == 3)
                    {
                        Console.WriteLine($"Frage 3: Tanken könnte schwierig werden, die Fähigkeit zum Segelfiegen wäre jetzt gut - Große Spannweite ist gefragt.");
                        if (Raumschiffe[11].Spannweite <= Raumschiffe[auswahlRaumschiff - 1].Spannweite)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }
                    }
                    else if (gezogeneFrage[j] == 4)
                    {
                        Console.WriteLine($"Frage 4: Wilde Tiere reagieren auf helle Farben allergisch - Sie gewinnen wenn Random Weiß oder Gelb.");
                        if (Raumschiffe[11].Farbe == "Weiß" || Raumschiffe[11].Farbe == "Gelb")
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }
                    }
                    else if (gezogeneFrage[j] == 5)
                    {
                        Console.WriteLine($"Frage 5: Die Marken mit Anfangbuchstaben a bzw. A sind an Ihrem Zielort verhasst. Eigenes Raumschiff mit Marke a... oder A... verliert.");
                        if (Raumschiffe[auswahlRaumschiff - 1].Marke[0] == 'a' || Raumschiffe[auswahlRaumschiff - 1].Marke[0] == 'A')
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
                        Console.WriteLine($"Frage 6: Die Bewohner an Ihrem Zielort mögen keine protzig aussehenden Raumschiffe - Länge und Spannweite sollten klein sein.");
                        if ((Raumschiffe[11].Laenge >= Raumschiffe[auswahlRaumschiff - 1].Laenge) && (Raumschiffe[11].Spannweite >= Raumschiffe[auswahlRaumschiff - 1].Spannweite))
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }

                    }
                    else if (gezogeneFrage[j] == 7)
                    {
                        Console.WriteLine($"Frage 7: Die Fahrt zum Zielort dauert sehr lange, Sie könnten verdursten - Die Geschwindigkeit sollte hoch sein.");
                        if (Raumschiffe[11].MaxGeschwindigkeit <= Raumschiffe[auswahlRaumschiff - 1].MaxGeschwindigkeit)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }

                    }
                    else if (gezogeneFrage[j] == 8)
                    {
                        Console.WriteLine($"Frage 8: Ihr Beifahrer mach Ärger - Der, der keinen Beifahrer hat, gewinnt.");
                        if (Raumschiffe[auswahlRaumschiff - 1].Beifahrer == "nein" || Raumschiffe[auswahlRaumschiff - 1].Beifahrer == "n")
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }

                    }
                    else if (gezogeneFrage[j] == 9)
                    {
                        Console.WriteLine($"Frage 9: Sie müssen zwischendurch anhalten und viele Leute mitnehmen, sie werden Ihnen helfen.");
                        if (Raumschiffe[11].AnzahlSitze <= Raumschiffe[auswahlRaumschiff - 1].AnzahlSitze)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }

                    }
                    else if (gezogeneFrage[j] == 10)
                    {
                        Console.WriteLine($"Frage 10: Die Reise ist schön, Sie wollen sie genießen, alles ist vorrätig - Die Geschwindigkeit sollte klein sein.");
                        if (Raumschiffe[11].MaxGeschwindigkeit >= Raumschiffe[auswahlRaumschiff - 1].MaxGeschwindigkeit)
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

                //Ende ohne Endemenue

                
                do
                {
                    Console.WriteLine($"\nBesteht der Wunsch Ihr Ergebnis zu verbessen? - Bitte (J)a oder (N)ein eingeben");
                    string endRunde = Console.ReadLine().ToLower();
                    if (endRunde == "ja" || endRunde == "j")
                    {
                    User.EndeFunktion(gewinnpunkte);//Methodenaufruf zu user.cs -> EndeFunktion(int punkte) - Gewinnpunkte werden übergeben
//                       EndeFunktion(gewinnpunkte);//Methodenaufruf zu user.cs -> EndeFunktion(int punkte) - Gewinnpunkte werden übergeben
                        break;
                    }
                    else if (endRunde == "nein" || endRunde == "n")
                    {
                        Console.WriteLine($"\nBitte unbedingt auch die Rettung per Boot und Auto spielen");

                        do
                        {
                            Console.WriteLine("\nNeues Spiel beginnnen? J(a) oder (N)ein");
                            string endRunde4 = Console.ReadLine().ToLower();
                            if (endRunde4 == "ja" || endRunde4 == "j")
                            {
                                User.Menue();//Methodenaufruf zu user.cs
                                break;
                            }
                            else if (endRunde4 == "nein" || endRunde4 == "n")
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine($"\nUngültige Eingabe - Bitte (J)a oder (N)ein eingeben");
                            }
                        } while (true);

                    }
                    else
                    {
                        Console.WriteLine($"\nUngültige Eingabe - Bitte (J)a oder (N)ein eingeben");
                    }
                } while (true);//(boolEnde == true);

            }//Void Fragenblock zu Ende
        


        }//Ende Void Aufruf zu Ende

    }


}
    