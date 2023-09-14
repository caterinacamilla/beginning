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
         List<string> names = new List<string> {"Luca", "Katharina", "Hans", "Linh", "Marcia", "Benny", "Niklas", "Lea"};
            Console.WriteLine("Welchen Buchstaben möchtest du assortieren?");
            string letter = Console.ReadLine();
            foreach(string name in names)
            {
                if(name.Contains(letter))
                {
                    Console.WriteLine(name);

                }

            }

        }
    }
}
