using Abenteuerspiel_Volker;
using System;
using System.ComponentModel.Design;
using System.Net.Mail;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using System.Xml;

namespace Abenteuerspiel_Volker
{
    internal class User
    {
        private string vorname;
        private string nachname;
        private int alter;
        private int groesse;


        public User(string vorname, string nachname, int alter, int groesse)
        {
            Vorname = vorname;
            Nachname = nachname;
            Alter = alter;
            Groesse = groesse;
        }

        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public int Alter { get => alter; set => alter = value; }
        public int Groesse { get => groesse; set => groesse = value; }



        public static void Start()
        {
            Console.WriteLine("Bitte Vorname Eingeben");
            string vorname = Console.ReadLine();
            Console.WriteLine("Bitte Nachname Eingeben");
            string nachname = Console.ReadLine();
            
            //Eingabe Alter
            Console.WriteLine("Bitte Alter eingeben - Werte von 1 - 500");
            int alter = Convert.ToInt32(Console.ReadLine());

            while (alter < 1 || alter > 500)
            {
                Console.WriteLine($"Bitte Alter eingeben - Werte von 1 - 500");
                alter = Convert.ToInt32(Console.ReadLine());
            }
            //Ende Eingabe Alter


            //Eingabe Grösse
            Console.WriteLine($"Bitte Groesse Eingeben - Werte von 1 - 1000");
            int groesse = Convert.ToInt32(Console.ReadLine());

            while (groesse < 1 || groesse > 1000)
            {
                Console.WriteLine($"Bitte Groesse eingeben - Werte von 1 - 1000");
                groesse = Convert.ToInt32(Console.ReadLine());
            }

            //Ende Eingabe Grösse





            User user1 = new User(vorname, nachname, alter, groesse);
            Console.WriteLine($" Vorname: {user1.Vorname},Nachname: {user1.Nachname},Alter: {user1.Alter},Grösse: {user1.Groesse}");

            /////// PASSWORT Eingabe Mindestens 2 Buchstaben und 2 Zahlen und ein Sonderzeichen. Eingabe erfolgt so lange bis die Bedingungen erfüllt sind.
            ////// Wenn die Bedingung erfüllt ist muss das Passwort nochmal eingegeben werden. Nach 3 Versuchen ist Schluß
            bool eingabeBool = true;       
            do
            {
                Console.WriteLine("Bitte ein Passwort eingeben mindestens 2 Buchstabe und 2 Zahlen und 1 Sonderzeichen");
                string passwort = Console.ReadLine();
                int laenge = passwort.Length;


                int zaehlerDigit = 0;
                int zaehlerLetter = 0;
                int zaehlerSonderz = 0;

                for (int i = 0; i < passwort.Length; i++)
                {
                    if (Char.IsDigit(passwort[i]) == true)
                    {
                        zaehlerDigit = zaehlerDigit + 1;
                    }
                    else if (Char.IsLetter(passwort[i]) == true)
                    {
                        zaehlerLetter = zaehlerLetter + 1;
                    }
                    else if (Char.IsLetterOrDigit(passwort[i]) == false)
                    {
                        zaehlerSonderz = zaehlerSonderz + 1;
                    }
                    else
                    {
                        Console.WriteLine("Irgendwas ging schief");
                    }
                }
                if (zaehlerDigit >= 2 && zaehlerLetter >= 2 && zaehlerSonderz >= 1)
                {
                    Console.WriteLine("Das Passwort erfüllt alle Bedingungen");
                    eingabeBool = false;
                    passwortpruefung(passwort); //Methodenaufruf passwort wird dann nochmal als passwortwhg eingegeben und mit dem bisherigen passwort überprüft
                }
   
            } while (eingabeBool == true);

            //Passwort wird noch mal eingegeben und mit dem bisherigen Passwort überprüft
                
            static  void passwortpruefung(string passwort)
            {
                bool pruefBool = true;
                do
                {
                    int anzahlWdh = 3; ;

                    //Das Passwort muss nochmal eingegeben werden. Maximal 3 mal dann muss es stimmen
                    for (int i = 0; i < anzahlWdh; i++)
                    {
                        Console.WriteLine("Passwort bitte nochmal eingeben");
                        string passwortWhg = Console.ReadLine();
                        if (passwortWhg == passwort)
                        {
                            Console.WriteLine("Super die Passworter stimmen überein");
                            pruefBool = false;
                            //Methodenaufruf für das Menue
                            User.Menue();
                            break;
                        }
                        else if (passwortWhg != passwort)
                        {
                            Console.WriteLine("Die Passwörter stimmen nicht überein, Bitte nochmal eingeben");
                            if (i == (anzahlWdh - 1))
                            {
                                Console.WriteLine("3ter Versuch gescheitet, Programm beendet - Nochmal von ganz vorne beginnen");
                                pruefBool = false;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Irgendwas ging schief");
                            
                        }
                    }//Ende for-Schleife
                } while (pruefBool == true);
            }//Ende Methode passwortpruefung
        }//Ende public void start()
        public static void Menue()
        {
            Console.WriteLine("Sie haben sich im Wald verirrt und können sich 1. von einem Raumschiff / 2. von einem Auto / 3. von einem Boot retten lassen.");
            Console.WriteLine("Bitte geben Sie '1', '2' oder '3' ein - Sie müssen sich dann im Wettkampf behaupten");
            int eingabe = Convert.ToInt32(Console.ReadLine());

            bool eingabeBool = true;
            do
            {
                if (eingabe == 1)
                {
                    Console.Clear();
                    Raumschiff.Aufruf();
                    eingabeBool = false;
                }
                else if (eingabe == 2)
                {
                    Console.Clear();
                    Auto.Aufruf();
                    eingabeBool = false;
                }
                else if (eingabe == 3)
                {
                    Console.Clear();
                    Boot.Aufruf();
                    eingabeBool = false;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte 1 oder 2 oder 3 eingeben");
                }
            } while (eingabeBool == true) ;
        }//Ende Menue



        public static void EndeFunktion(int punkte)//Wird von der Raumschiff/Auto/Boot.cs aufgerufen
 //      public void EndeFunktion(int punkte)//Wird von der Raumschiff/Auto/Boot.cs aufgerufen
        {
            do
            {
 
                Console.WriteLine($"\nAm Ende des Abenteuers bittet Sie ein furchteregender Bewohner um einen Gefallen - Gehen Sie darauf ein? - (J)a oder (N)ein");
                string Ende = Console.ReadLine().ToLower();
                if (Ende == "ja" || Ende == "j")
                {
                    punkte = punkte + 2;
                    Console.WriteLine($"\nIhr Punktestand hat sich um 2 Punkte verbessert");
                    monster(punkte);//Methodenaufruf zur Methode Monster, die Punkte werden übergeben, monster (int punkte)                   


                }
                else if (Ende == "nein" || Ende == "n")
                {
                    monster(punkte);//Methodenaufruf zur Methode Monster, die Punkte werden übergeben, monster (int punkte)
                }
                else
                {
                    Console.WriteLine($"\nUngültige Eingabe - Bitte (J)a oder (N)ein eingeben");
                }
            } while (true); 
        }//Ende Ende Ende Funktion


 

        ////////static void monster(int punkte)
        static void monster (int punkte)
        {
            do
            {
                Console.WriteLine($"\nWild aussehende Monster kommen auf Sie zu, was tun Sie? 1 = wegrennen, 2 = verstecken, 3 = kämpfen");
                int monster = Convert.ToInt32(Console.ReadLine());
                if (monster == 1)
                {
                    punkte = punkte + 1;
                    Console.WriteLine($"\nEntscheidung war so mittel - 1 Punkt zusätzlich. Gesamtpunktzahl: {punkte}");
                    Wegrennen(punkte);//Methodernaufruf die Punkte werden übergaben an Wegrennen (int punkte)
                }
                else if (monster == 2)
                {
                    punkte = punkte + 2;
                    Console.WriteLine($"\nEntscheidung war gut - 2 Punkte zusätzlich. Gesamtpunktzahl: {punkte}");
                    Verstecken(punkte);//Methodenaufruf die Punkte werden übergaben an Verstecken (int punkte)

                }
                else if (monster == 3)
                {
                    punkte = punkte - 1;
                    Console.WriteLine($"\nEntscheidung war schlecht - 2 Punkt abzug. Gesamtpunktzahl: {punkte}");
                    Kaempfen(punkte);//Methodenaufruf die Punkte werden übergaben an Kaempfen (int punkte)
                }
                else
                {
                    Console.WriteLine($"Bitte nochmal 1,2 oder 3 eingeben");
                }

            } while (true);
        }

   
        static void Wegrennen(int punkte) 
        {
            do
            {

                Console.WriteLine($"\nIst das Gelände übersichtlich - (Skala 1-5) 5=sehr übersichtlich, 1=extrem unübersichtlich");
                int bewertung = Convert.ToInt32(Console.ReadLine());
                if (bewertung >= 0 && bewertung <= 5)
                {
                    switch (bewertung)
                    {
                        case 1:
                            punkte = punkte + 3;
                            Console.WriteLine($"\nSie bekommen 3 Punkte zusätzlich der Punktestand ist {punkte}.");
                            break;
                        case 2:
                            punkte = punkte + 2;
                            Console.WriteLine($"\nSie bekommen 2 Punkte zusätzlich der Punktestand ist {punkte}.");
                            break;
                        case 3:
                            punkte = punkte + 1;
                            Console.WriteLine($"\nSie bekommen 1 Punkt zusätzlich der Punktestand ist {punkte}.");
                            break;
                        case 4:
                            punkte = punkte + 0;
                            Console.WriteLine($"\nSie bekommen 0 Punkte zusätzlich der Punktestand ist {punkte}.");
                            break;
                        case 5:
                            punkte = punkte - 1;
                            Console.WriteLine($"\nSie bekommen 1 Punkt abgezogen der Punktestand ist {punkte}.");
                            break;
                        default:
                            Console.WriteLine($"\nUngültige Eingabe");
                            break;
                    }
                     
                Bewertung(punkte);//Funktionsaufruf zur Bewertung des Spiels
                }

                else
                {
                    Console.WriteLine("\nBewertung ungültig. Bitte erneute Eingabe");
                }
            } while (true);
        }



        static void Verstecken(int punkte)
        {
            do
            {

                Console.WriteLine($"\nGibt es gute Möglichkeiten unentdeckt zu bleiben? - (Skala 1-5) 5=eher nicht, 1=ja, auf alle Fälle");
                int bewertung = Convert.ToInt32(Console.ReadLine());
                if (bewertung >= 0 && bewertung <= 5)
                {
                    switch (bewertung)
                    {
                        case 1:
                            punkte = punkte + 3;
                            Console.WriteLine($"\nSie bekommen 3 Punkte zusätzlich der Punktestand ist {punkte}.");
                            break;
                        case 2:
                            punkte = punkte + 2;
                            Console.WriteLine($"\nSie bekommen 2 Punkte zusätzlich der Punktestand ist {punkte}.");
                            break;
                        case 3:
                            punkte = punkte + 1;
                            Console.WriteLine($"\nSie bekommen 1 Punkt zusätzlich der Punktestand ist {punkte}.");
                            break;
                        case 4:
                            punkte = punkte + 0;
                            Console.WriteLine($"\nSie bekommen 0 Punkte zusätzlich der Punktestand ist {punkte}.");
                            break;
                        case 5:
                            punkte = punkte - 1;
                            Console.WriteLine($"\nSie bekommen 1 Punkt abgezogen der Punktestand ist {punkte}.");
                            break;
                        default:
                            Console.WriteLine($"\nUngültige Eingabe");
                            break;
                    }

                    Bewertung(punkte);//Funktionsaufruf zur Bewertung des Spiels mit Übergabe der Punkte
                }

                else
                {
                    Console.WriteLine("\nBewertung ungültig. Bitte erneute Eingabe");
                }
            } while (true);
        }


        static void Kaempfen (int punkte)
        {
            do
            {

                Console.WriteLine($"\nWurden alle anderen Möglichkeiten gedanklich geprüft?? - (Skala 1-5) 5=eher nicht, 1=ja, auf alle Fälle");
                int bewertung = Convert.ToInt32(Console.ReadLine());
                if (bewertung >= 0 && bewertung <= 5)
                {
                    switch (bewertung)
                    {
                        case 1:
                            punkte = punkte + 3;
                            Console.WriteLine($"\nSie bekommen 3 Punkte zusätzlich der Punktestand ist {punkte}.");
                            break;
                        case 2:
                            punkte = punkte + 2;
                            Console.WriteLine($"\nSie bekommen 2 Punkte zusätzlich der Punktestand ist {punkte}.");
                            break;
                        case 3:
                            punkte = punkte + 1;
                            Console.WriteLine($"\nSie bekommen 1 Punkt zusätzlich der Punktestand ist {punkte}.");
                            break;
                        case 4:
                            punkte = punkte + 0;
                            Console.WriteLine($"\nSie bekommen 0 Punkte zusätzlich der Punktestand ist {punkte}.");
                            break;
                        case 5:
                            punkte = punkte - 1;
                            Console.WriteLine($"\nSie bekommen 1 Punkt abgezogen der Punktestand ist {punkte}.");
                            break;
                        default:
                            Console.WriteLine($"\nUngültige Eingabe");
                            break;
                    }

                   Bewertung(punkte);//Funktionsaufruf um Spiel zu bewerten mit Übergabe der Punkte
                }

                else
                {
                    Console.WriteLine("\nBewertung ungültig. Bitte erneute Eingabe");
                }
            } while (true);
        }



        static void Bewertung(int punkte)
        {
            do
            {

                Console.WriteLine($"\nDie letzte Chance das Ergebnis zu verbessern - War das Spiel gut? - Skala von 1-5 (5 sehr gut, 1 sehr schlecht) ");
                int bewertung = Convert.ToInt32(Console.ReadLine());
                if (bewertung >= 0 && bewertung <= 5)
                {
                    punkte = punkte + bewertung;
                    Console.WriteLine($"\nIhr Punktestand hat sich um {bewertung} Punkte auf {punkte} Punkte verbessert");
                    EndeTotal(punkte);//Funktionsaufruf um Spiel zu beenden geht in die User cs
                }

                else
                {
                    Console.WriteLine("\nBewertung ungültig. Bitte erneute Eingabe");
                }
            } while (true);
        }


        static void EndeTotal(int punkte)
        {
            ////bool boolEnde4 = true;
            do
            {
                Console.WriteLine($"\nSie haben {punkte} Punkte erreicht.");
                Console.WriteLine($"\nNeues Spiel beginnnen? J(a) oder (N)ein");
                string endRunde4 = Console.ReadLine().ToLower();
                if (endRunde4 == "ja" || endRunde4 == "j")
                {
                    ////boolEnde4 = false;
                    User.Menue();//Funktionsaufruf Munue() in der User.cs
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
            } while (true); //(boolEnde4 == true);
        }//Ende Methode Ende Total
    }//Ende Class Usser
}
