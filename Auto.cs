using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abenteuerspiel_Volker
{
    internal class Auto: Verkehrsmittel 
    {
        int anzahlRaeder;

        public Auto(string marke, int maxGeschwindigkeit, string farbe, int laenge, int anzahlSitze, string beifahrer, int anzahlRaeder)
        {
            Marke = marke;
            MaxGeschwindigkeit = maxGeschwindigkeit;
            Farbe = farbe;
            Laenge = laenge;
            AnzahlSitze = anzahlSitze;
            Beifahrer = beifahrer;
            AnzahlRaeder = anzahlRaeder;
        }
        public int AnzahlRaeder { get => anzahlRaeder; set => anzahlRaeder = value; }

 
        public static void Aufruf()
        {
            Auto[] Autos = new Auto[12];//Das Random erzeugte Auto wird später auf Index 11 d.h. auf das 12te Feld gesetzt 
            Console.WriteLine("Sie haben Auto ausgewählt.");
            Console.WriteLine("Stellen Sie nun drei eigene Autos zusammen.");

            for (int i = 0; i < 3; i++)
            {

                //Eingabe Marke
                Console.WriteLine($"Modell {i + 1}:Bitte Marke Eingeben.");
                string marke = Console.ReadLine();
                //Ende Eingabe Marke

                //Eingabe maxGeschwindigkeit
                Console.WriteLine($"Modell {i + 1}:Bitte maxGeschwindigkeit eingeben - Werte von 1 - 10.000.");
                int maxGeschwindigkeit = Convert.ToInt32(Console.ReadLine());

                while (maxGeschwindigkeit < 1 || maxGeschwindigkeit > 10000)
                {
                    Console.WriteLine($"Modell {i + 1}:Bitte maxGeschwindigkeit eingeben - Werte von 1 - 10.000.");
                    maxGeschwindigkeit = Convert.ToInt32(Console.ReadLine());
                }
                //Ende Eingabe maxGeschwindigkeit           

                //Eingabe Farbe
                Console.WriteLine($"Modell {i + 1}:Bitte Farbe eingeben - Die Auswahl ist Rot, Gelb, Blau, Grün, Weiß, Schwarz, Orange.");

                string[] farben = { "Rot", "Gelb", "Blau", "Grün", "Weiß", "Schwarz", "Orange" };
                string farbe = Console.ReadLine();
                bool farbeBool = true;

                while (farbeBool == true)
                {
                    foreach (string einzelfarben in farben) // Jede Farbe in dem Sting-Array farben wird durchlaufen
                    {
                        if (einzelfarben == farbe)//Prüfung ob die jeweilige einzelfarbe des Sting-Array mit der vom user eingebenen farbe übereinstimmt 
                        {
                            farbeBool = false;//Wenn false war die Eingabe richtig, und die while Schleife wird verlassen. Der zuerst eingelesene Wert bleibt
                        }

                    }
                    if (farbeBool == true) Console.WriteLine($"Modell {i + 1}:Bitte Farbe eingeben - Die Auswahl ist Rot, Gelb, Blau, Grün, Weiß, Schwarz, Orange.");
                    if (farbeBool == true) farbe = Console.ReadLine();
                }
                //Ende Eingabe Farbe

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
                Console.WriteLine($"Modell {i + 1}: Bitte angeben ob mit = (J)a oder ohne = (N)ein Beifahrer.");
                string beifahrer = Console.ReadLine().ToLower();//Macht aus Großbuchstaben Kleinbuchstaben


                string[] beifahrerString = { "J", "Ja", "N", "Nein", "j", "ja", "n", "nein" };//Die Grossbuchstaben hätte ich weglassen können wegen ToLower()
                bool beifahrerBool = true;

                while (beifahrerBool == true)
                {
                    foreach (string einzelbeifahrer in beifahrerString)//Jede vorgegebene Antwortmöglichkeit in dem String-Array befahrerString wird durchlaufen
                    {
                        if (einzelbeifahrer == beifahrer) //Prüfung ob die jeweilige Anwortmöglichkeit (einzelbeifahrer) des String-Arrays mit dem vom user eingebenen beifahrer übereinstimmt
                        {
                            beifahrerBool = false;//Wenn false war die Eingabe richtig, und die while Schleife wird verlassen. Der zuerst eingelesene Wert bleibt
                        }

                    }
                    if (beifahrerBool == true) Console.WriteLine($"Modell {i + 1}: Bitte Angeben ob mit = (J)a oder ohne = (N)ein Beifahrer.");
                    if (beifahrerBool == true) beifahrer = Console.ReadLine().ToLower();
                }
                //Ende Eingabe Beifahrer


                //Eingabe Anzahl Räder
                Console.WriteLine($"Modell {i + 1}: Bitte die gewünschte Anzahl Räder des Autos angeben - Werte von 1 - 50.");
                int anzahlRaeder = Convert.ToInt32(Console.ReadLine());//Umwandlung String in int Zahl

                while (anzahlRaeder < 1 || anzahlRaeder > 50)
                {
                    Console.WriteLine($"Modell {i + 1}:Bitte die gewünschte Anzahl Räder des Autos eingeben - Werte von 1 - 50.");
                    anzahlRaeder = Convert.ToInt32(Console.ReadLine());//Umwandlung String in int Zahl
                }
                //Ende Eingabe Anzahl Räder


                //Aufruf Konstruktor die 3 Autos werden erzeugt. Umwandlung in Eigenschaften
                Autos[i] = new Auto(marke, maxGeschwindigkeit, farbe, laenge, anzahlSitze, beifahrer, anzahlRaeder);
                ////////////////////////Console.WriteLine($"Deine 3 Raumschiffe: {Raumschiffe[i].Marke}, {Raumschiffe[i].MaxGeschwindigkeit}");


            }

            Console.Clear();
            //Ausgabe der gewählten Autos - Index 0-2 d.h. die Autos sollen 1-3 heißen deshalb i+1
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Autos {i + 1}: Marke: {Autos[i].Marke}, MaxGeschw: {Autos[i].MaxGeschwindigkeit}, Farbe: {Autos[i].Farbe}, Länge: {Autos[i].Laenge}, Anzahl Sitze: {Autos[i].AnzahlSitze}, Beifahrer: {Autos[i].Beifahrer}, Anzahl Räder: {Autos[i].AnzahlRaeder}");
            }


            //Der Computer stellt sich sein eigenes Auto zusammen

            //*Die Marke wird vom Computer erzeugt 5 einzel per Random angwählte Chars werden zusammengefügt zu einem string
            char[] chars = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            char[] anzahlZeichenMarke = new char[5];//Die Größe des Char-Array wird auf 5 festgelegt
            string anzahlZeichenMarkeString = "";//leerer String wird initialisiert

            Random rand = new Random();//Definition rand - Zur Erzeugung einer Zufallszahl
            for (int i = 0; i < 5; i++)
            {
                int j = rand.Next(0, chars.Length - 1);//Zufallswert j von 0 - (Länge char Array -1) wird erzeugt - entsprechend den Índizes des char Arrays.
                anzahlZeichenMarke[i] = chars[j];//Befüllung des 5-stelligen char Arrays mit den definierten Zufallsbuchstaben - in char[] chars = "ab.." z.B j=3 ist b"
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
            Random rand3 = new Random();//Definition rand3 -Zur Erzeugung einer Zufallsfarbe
            int k = rand3.Next(0, farbenRandom.Length - 1);//Eine Zufallszahl zwische 0- (farben lange-1) wird erzeugt: hier 0-6 - entsprechend denIndizes des Array String.
            farbenRandomEnde = farbenRandom[k];//Befüllung mit den entsprechenden Zufallswerten z.B. bei 2 ist es Blau
            ////////////////////Console.WriteLine($"{farbenRandomEnde}");
            //Ende die Farbe wird vom Computer gewählt

            //*Die Länge wird vom Computer erzeugt Werte zwischen 1-1000
            Random rand4 = new Random();//Definition - Zur Erzeugung einer Zufallszahl
            int maxLaengeRandom = rand4.Next(1, 1000);//Computer wählt Werte zwischen 1-1000
            ////////////////////Console.WriteLine($"{maxLaengeRandom}");
            //*Ende die Länge wird vom Computer erzeugt

            //*Die Anzahl Sitze wird vom Computer erzeugt Werte zwischen 1-100
            Random rand5 = new Random();//Definition - Zur Erzeugung einer Zufallszahl
            int maxSitzeRandom = rand5.Next(1, 100);//Computer wahlt Werte zwischen 1-100
            ////////////////////Console.WriteLine($"{maxSitzeRandom}");
            //*Ende die Anzahl Sitze wird vom Computer erzeugt


            //*Beifahrer wird vom Computer erzeugt
            string[] beifahrerRandom = { "j", "n", "ja", "nein" };//Definition String-Array
            string beifahrerRandomEnde = "";//Definition leerer String
            Random rand6 = new Random();//Definition - Zur Erzeugung einer Zufallsfarbe
            int l = rand6.Next(0, beifahrerRandom.Length - 1);//Zufallswert 0-3 wird erzeugt, entsprechend den Indizes beifahrerRandom-Array
            beifahrerRandomEnde = beifahrerRandom[l];//Befüllung mit den entsprechenden Zufallswerten z.B. 2="ja"
            ////////////////////Console.WriteLine($"{beifahrerRandomEnde}");                 
            //*Beifahrer Ja/Nein wird vom Computer erzeugt

            //*Spannweite wird vom Computer erzeugt Werte zwischen 1-1000
            Random rand7 = new Random();//Definition - Zur Erzeugung einer Zufallszahl
            int anzahlRaederRandom = rand7.Next(1, 50);//Computer wählt Werte zwischen 1-15
            ////////////////////Console.WriteLine($"{anzahlRaederRandom}");
            //*Ende die Anzahl Räder wird vom Computer erzeugt


            //Der Computer hat folgendes Auto per Random erzeugt. // Der Konstruktor wird wieder aufgerufen und das Auto erzeugt. Umwandlung in Eigenschaften
            Autos[11] = new Auto(anzahlZeichenMarkeString, maxGeschwindingkeitRandom, farbenRandomEnde, maxLaengeRandom, maxSitzeRandom, beifahrerRandomEnde, anzahlRaederRandom);
            //Ende Der Computer hat folgendes Auto per Random erzeugt.;

            Console.WriteLine($"\nDer Computer spielt mit folgendem Auto : Marke: {Autos[11].Marke}, MaxGeschw: {Autos[11].MaxGeschwindigkeit}, Farbe: {Autos[11].Farbe}, Länge: {Autos[11].Laenge}, Anzahl Sitze: {Autos[11].AnzahlSitze}, Beifahrer: {Autos[11].Beifahrer}, Anzahl Räder: {Autos[11].AnzahlRaeder}\n");


            //Der Computer wählt per Zufall 3 Fragen aus 10 vorgegebenen Fragen aus
            //
            //Das Array anzahlFragen wird mit 1-10 gefüllt
            int[] anzahlFragen = new int[10]; // Definition eines 10-stelligen Arrays. Hier wurde tatsächlich nur die Länge verwendet

            Random rnd = new Random();//Definition - Zur Erzeugung einer Zufallszahl
            int[] gezogeneFrage = new int[3];//das Array für die gezogenen Zahlen wird definiert . Hier sollen 3 Werte aus dem Bereich 1-10 stehen

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
                if (gezogeneFrage[i] == 1) Console.WriteLine($"Frage 1: Sie müssen über das riesige Gebirge fahren, unwegsames Gelände.");
                if (gezogeneFrage[i] == 2) Console.WriteLine($"Frage 2: Riesige große Vögel warten in der Wüste auf Sie.");
                if (gezogeneFrage[i] == 3) Console.WriteLine($"Frage 3: Tanken könnte schwierig werden, die Möglichkeit zu sparen wäre jetzt gut.");
                if (gezogeneFrage[i] == 4) Console.WriteLine($"Frage 4: Wilde Tiere reagieren auf helle Farben allergisch.");
                if (gezogeneFrage[i] == 5) Console.WriteLine($"Frage 5: Die Marken mit Anfangsbuchstaben a bzw. A sind an ihrem Zielort verhasst.");
                if (gezogeneFrage[i] == 6) Console.WriteLine($"Frage 6: Die Bewohner an ihrem Zielort mögen keine protzig aussehenden Autos.");
                if (gezogeneFrage[i] == 7) Console.WriteLine($"Frage 7: Die Fahrt zum Zielort dauert sehr lange, Sie könnten verdursten.");
                if (gezogeneFrage[i] == 8) Console.WriteLine($"Frage 8: Ein Beifahrer fehlt mir.");
                if (gezogeneFrage[i] == 9) Console.WriteLine($"Frage 9: Sie müssen zwischendurch anhalten und viele Leute mitnehmen, sie werden Ihnen helfen.");
                if (gezogeneFrage[i] == 10) Console.WriteLine($"Frage 10: Die Reise ist schön, Sie werden sie genießen, alles ist vorrätig.");

            }

            Console.WriteLine($"\nSie kennen jetzt das Auto gegen das Sie spielen werden und wissen jetzt auch auf was es ankommt, wählen Sie nun ihr Auto aus (1,2 oder 3).");

            int auswahlAuto = Convert.ToInt32(Console.ReadLine());

            //while (auswahlRaumschiff < 1 || auswahlRaumschiff > 3)
            //{
            //    Console.WriteLine($"\nHallo User: Du kennst jetzt das Raumschiff gegen das du Spielen wirst und du weiß jetzt auch auf was es ankommt, Wähle nun Dein Raumschiff auf (1,2 oder 3) ");
            //    auswahlRaumschiff = Convert.ToInt32(Console.ReadLine());
            //}


            Fragenblock(auswahlAuto);//Methodenaufruf zu void Fragenblock. Die Zeile darunter

 
            void Fragenblock(int auswahlAuto)
            {
                int i = auswahlAuto; // i repräsentiert das von uns ausgewählte Auto // auswahlAuto geht von 1-3 damit es zum Index 0-2 passt auswahlAuto-1
                int gewinnpunkte = 0;
                Console.WriteLine($"\nHallo User, Auto Nr. {i} wurde gewählt\n");//Enthält die Werte 1-3
                ////Console.Clear();

                for (int j = 0; j < 3; j++)// j sind die 3 gezogenen Fragen aus dem Bereich der 10 Fragen
                {
                    if (gezogeneFrage[j] == 1)
                    {
                        Console.WriteLine($"Frage 1: Sie müssen über das riesige Gebirge fahren, unwegsames Gelände - Eine Vielzahl von Rädern ist günstig.");
                        if (Autos[11].AnzahlRaeder <= Autos[auswahlAuto - 1].AnzahlRaeder)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }
                    }
                    else if (gezogeneFrage[j] == 2)
                    {
                        Console.WriteLine($"Frage 2: Riesige große Vögel warten im der Wüste auf Sie - Das Auto sollte möglichst lang sein.");
                        if (Autos[11].Laenge <= Autos[auswahlAuto - 1].Laenge)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }
                    }
                    else if (gezogeneFrage[j] == 3)
                    {
                        Console.WriteLine($"Frage 3: Tanken könnte schwierig werden, die Möglichkeit zu sparen wäre jetzt gut - Wenig Räder sind gefragt.");
                        if (Autos[11].AnzahlRaeder >= Autos[auswahlAuto - 1].AnzahlRaeder)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }
                    }
                    else if (gezogeneFrage[j] == 4)
                    {
                        Console.WriteLine($"Frage 4: Wilde Tiere reagieren auf helle Farben allergisch - Sie gewinnen wenn Random Weiß oder Gelb.");
                        if (Autos[11].Farbe == "Weiß" || Autos[11].Farbe == "Gelb")
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }
                    }
                    else if (gezogeneFrage[j] == 5)
                    {
                        Console.WriteLine($"Frage 5: Die Marken mit Anfangsbuchstaben a bzw. A sind an Ihrem Zielort verhasst. Sie gewinnnen wenn eigene Marke nicht A... oder a... ist.");
                        if (Autos[auswahlAuto - 1].Marke[0] == 'a'|| Autos[auswahlAuto - 1].Marke[0] == 'A')
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
                        Console.WriteLine($"Frage 6: Die Bewohner an Ihrem Zielort mögen keine protzig aussehenden Autos - Länge und Anzahl Räder sollten klein sein.");
                        if ((Autos[11].Laenge >= Autos[auswahlAuto - 1].Laenge) && (Autos[11].AnzahlRaeder >= Autos[auswahlAuto - 1].AnzahlRaeder))
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }

                    }
                    else if (gezogeneFrage[j] == 7)
                    {
                        Console.WriteLine($"Frage 7: Die Fahrt zum Zielort dauert sehr lange, Sie könnten verdursten - Die Geschwindigkeit sollte hoch sein.");
                        if (Autos[11].MaxGeschwindigkeit <= Autos[auswahlAuto - 1].MaxGeschwindigkeit)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }

                    }
                    else if (gezogeneFrage[j] == 8)
                    {
                        Console.WriteLine($"Frage 8: Ihr Beifahrer hilft Ihnen - Der, der keinen Beifahrer hat, verliert.");
                        if (Autos[auswahlAuto - 1].Beifahrer == "ja" || Autos[auswahlAuto - 1].Beifahrer == "j")
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }

                    }
                    else if (gezogeneFrage[j] == 9)
                    {
                        Console.WriteLine($"Frage 9: Sie müssen zwischendurch anhalten und viele Leute mitnehmen, sie werden Ihnen helfen.");
                        if (Autos[11].AnzahlSitze <= Autos[auswahlAuto - 1].AnzahlSitze)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }

                    }
                    else if (gezogeneFrage[j] == 10)
                    {
                        Console.WriteLine($"Frage 10: Die Reise ist schön, Sie werden sie genießen, alles ist vorrätig - Die Geschwindigkeit sollte klein sein.");
                        if (Autos[11].MaxGeschwindigkeit >= Autos[auswahlAuto - 1].MaxGeschwindigkeit)
                        {
                            gewinnpunkte = gewinnpunkte + 1;
                            //break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("Irgendwas ging hier schief");
                    }


                }
                Console.WriteLine($"\nGewinnpunkte: {gewinnpunkte}");
                if (gewinnpunkte == 0)
                {
                    Console.WriteLine($" O Punkte, dass war nichts leider verloren.");
                }
                else if (gewinnpunkte == 1)
                {
                    Console.WriteLine($" 1 Punkt, reicht leider nicht für den Ernstfall.");
                }
                else if (gewinnpunkte == 2)
                {
                    Console.WriteLine($" 2 Punkte, gute Leistung.");
                }
                else if (gewinnpunkte == 3)
                {
                    Console.WriteLine($" 3 Punkte, besser geht es nicht.");
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

        }//Void Aufruf ist Zuende

    }


}
