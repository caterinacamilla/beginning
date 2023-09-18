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


        Console.WriteLine("Zähle die Vorkommnisse der jeweiligen Buchstaben im Wort MissiSsiPpi");
        Console.WriteLine("------------------");

      string wort = "Mississippi";
      int m = wort.Count(c => c == 'M');
      int i = wort.Count(c => c == 'i');
      int s = wort.Count(c => c == 's'|| c =='S');
      int p = wort.Count(c => c == 'p'|| c =='P');
      Console.WriteLine($"Im Wort MissiSsiPpi kommt der Buchstabe m {m} mal, i {i} mal, s {s} mal und p {p} mal vor.");
    }
}
}