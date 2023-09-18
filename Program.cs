using System.ComponentModel;

using System.Numerics;

using System.Security.Cryptography;

using System.Security.Cryptography.X509Certificates;
namespace HelloWorld
{
    class Program
    { 
        static void Main(string[] args)
        {
            //Wiederholung
            //Initialisiere 2 Zahlen und gebe das Ergebnis der Addition auf der Console aus
            //"Das Ergebnis von zahl1 und zahl2 ist XYZ"

            int zahl1 = 1;
            int zahl2 = 2;
            int ergebnis = zahl1 + zahl2;
            Console.WriteLine ($"Das ERgebnis von {zahl1} und {zahl2} ist {ergebnis}");

            //Wiederholung
            //Lasse vom Nutzer einen Text eingeben und gebe folgende Punkte aus
            //Länge des Textes
            //Anzahl wie oft Buchstabe h auftaucht

            Console.WriteLine ("Gebe mir einen Text mit viele h indem");
            string mytext = Console.ReadLine();
            Console.WriteLine (mytext.Length);
            mytext.Split('H');
            Console.WriteLine (mytext.Split('H').Length);

            
            //Wiederholung
            //Lasse vom Nutzer einen Text eingeben und gebe folgende Punkte aus
            //- Länge des Textes
            //- Anzahl  wie oft Buchstabe h auftaucht            

            Console.WriteLine("Gebe mir einen Text");
            string eingegebenerText = Console.ReadLine();
            int laengetext = eingegebenerText.Length;
            Console.WriteLine("Die Länge des Textes ist " + laengetext);
            
            //Möglichkeit 1
            //string[] splittedText = eingegebenerText.Split("h");
            
            //Möglichkeit 2
            int count = 0;
            for(int i = 0;i< eingegebenerText.Length;i++)
            {
                if(eingegebenerText[i] == 'h')
                {
                    count++;
                }
            }
            Console.WriteLine($"Es gibt {count} h's in deinem Text.");
           //Möglichkeit 2b
           foreach(char c in eingegebenerText)
           {
                if(c == 'h')
                {
                    count++;
                }
           }

           //Möglichkeit
           int numberofh = eingegebenerText.Count(c => c == 'h');
           Console.WriteLine($"Es gibt {numberofh} h's in deinem Text");

            //Frage den Nutzer wieviele Zahlen er in einem Array ingeben möchte
            //und lasse ihn anschließend mit Zahlen befüllen
            //Gebe anschließend die Größte und die Kleinste Zahl und den Durchschnitt aus.

            Console.WriteLine ("Gebe mir die gewünschte Größe deines Arrays an");
            string eingabe = Console.ReadLine ();
            int groese = Convert.ToInt16(eingabe);
            int [] myArray = new int [groese];
        }

        
    }
}