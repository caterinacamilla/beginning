using System.ComponentModel;

using System.Numerics;

using System.Security.Cryptography;

using System.Security.Cryptography.X509Certificates;
namespace HelloWorld
{
    class Program
    { static void Main(string[] args)
        { Console.WriteLine("Schreibe etwas!");
            string mytext = Console.ReadLine();
            string mytext2 = mytext.Replace("g","u").Replace("G","U");
}
}}
