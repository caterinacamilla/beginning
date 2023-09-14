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
            List<string> names = new List<string> {"Luca", "Katharina", "Hans", "Marcia", "Benny", "Lea"};
            foreach(string name in names)
            {
                if(name.Contains('e'))
                {
                    Console.WriteLine(name);
                }
            }
        }
    }
}
