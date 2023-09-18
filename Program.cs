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
          // Zähle die Vorkommnisse der einzelnen buchstaben in Mississippi
          // Groß-  und Kleinschreibung kann ignoriert werden
          //Im Wort Mississippi kommt der Buchstabe 
          //p = 2mal vor
          //i = 1mal vor
          //s =4 mal vor
          //...



       string text = "MissiSssssssiPpi";
            text = text.ToLower();
            int amountP = text.Count(p=>p =='p');
            int amountM = text.Count(p=>p =='m');
            int amountI = text.Count(p=>p =='i');
            int amountS = text.Count(p=>p =='s');

            Console.WriteLine("Es kommen im Text" + text + "folgende buchstaben vor");
            Console.WriteLine("p:" + amountP);
            Console.WriteLine("m:" + amountM);
            Console.WriteLine("i:" + amountI);
            Console.WriteLine("s:" + amountS);
    }
}
}