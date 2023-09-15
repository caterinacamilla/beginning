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
            Console.WriteLine ("mi dà un numero a caso tra 0 e 101");
            int nonloso = Convert.ToInt16 (Console.ReadLine ());
            Random random = new Random ();
            int numberToGuess = random.Next (0,101);
            while (numberToGuess != nonloso){ 
                //zahl wurde nicht getroffen             
                Console.WriteLine("Du hast verloren");

                if(nonloso < numberToGuess)
                {
                    Console.WriteLine("Die gesuchte Zahl ist größer");

                }
                else
                {
                    Console.WriteLine("Die gesuchte Zahl ist kleiner");
                }
                nonloso = Convert.ToInt16 (Console.ReadLine ());
            }
                
            

            Console.WriteLine ("hai vinto");
        }

        
    }
}