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
                Console.WriteLine("peccato,hai perso");

                if(nonloso < numberToGuess)
                {
                    Console.WriteLine("il numero che stai cercando e più grande");
                }
                else
                {
                    Console.WriteLine("il numero che stai cercando e più piccolo");
                }
                nonloso = Convert.ToInt16 (Console.ReadLine ());
            }
                
            

            Console.WriteLine ("congratulazione,hai vinto");
        }

        
    }
}