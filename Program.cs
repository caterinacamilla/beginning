using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Gebe mir deinen Namen!");
            string name = Console.ReadLine();

            Console.WriteLine("Sage mir wie alt du bist!");
            int age = Convert.ToInt16(Console.ReadLine());
            int alterin10 = age + 10;

            Console.WriteLine($"hello,   {name}!   Dein Alter ist {age} in 10 Jahren bin ich {alterin10}" ); 
            Console.WriteLine (Gebe mir eine Zahl);
            static void Main(string[] args){

        string text = "Das ist ein Text";

        Console.WriteLine(text);

        int zahl = 21;

        Console.WriteLine(zahl);

        double kommazahl = 21.3;

        Console.WriteLine(kommazahl);

        float weiterflieskomma = 21.354763F;

        Console.WriteLine(weiterflieskomma);

        decimal flieskomma = 21.5M;

        Console.WriteLine(flieskomma);

        bool wahrheitswert = true;

        Console.WriteLine(wahrheitswert);

        bool anders = false;

        Console.WriteLine(anders);

        char buchstabe = (char)48;

        Console.WriteLine(buchstabe);

        long langzahl = 123456789123456789;

        Console.WriteLine(langzahl);

        uint positiveZahldoppeltsolang = 123;

        Console.WriteLine(positiveZahldoppeltsolang);

 

        string[] myArray = new string[10];

        myArray[0] = "erster Wert";

        myArray[9] = "letzter Wert";

 

        List<string> myList = new List<string>();

        myList.Add("Luca");

        myList.Add("Katharina");    

        Console.WriteLine(myList[0]);

        Console.WriteLine(myList[1]);

has context menu
Compose
            
        }
        // Frage den Nutzer nach der ersten Zahl
    }
}  // Frage den Nutzer nach der ersten 
// Gebe das Ergebnis auf der Console aus 
// "Das Ergebnis aus {(Zahl1)} - {(Zahl2)} = {(Ergebnis)}
