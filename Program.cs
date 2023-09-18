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
          
           //Frage den Nutzer nach einer Zahl und gebe die Zahlen rückwärts aus
          //p.e. 65 => 64, 63, 62, 61, ...

            Console.WriteLine("Gib eine Zahl ein");
            Console.WriteLine("------------------");
          for(int zahl = Convert.ToInt32(Console.ReadLine()); zahl>=0; zahl--)
          {
            Console.WriteLine(zahl);
          }
        
    }
}
}
