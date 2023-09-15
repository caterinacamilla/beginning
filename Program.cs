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
            
            string operators = "";
            do{
                Console.WriteLine ("Gebe mir ein Rechenzeichen (+, -, *, /)");
            }while (operators != "+" && operators != "-" && operators != "*" && operators != "/"  );

            int zahl1 = 16;

            int zahl2 = 32;
            switch(operators)
            {
                case "+":
                    addition(zahl1,zahl2);
                    break;
                case "-":
                    substraction(zahl1,zahl2);
                    break;
                case "*":
                    multiplication(zahl1,zahl2);
                    break;
                case "/":
                    division(zahl1,zahl2);
                    break;
                default:
                    Console.WriteLine ("unknown Operator"); 
                    break;
            }
        }
        static void addition (int zahl1, int zahl2)
        { 
            Console.WriteLine (zahl1 + zahl2);
        }
        static void substraction (int zahl1, int zahl2)
        { Console.WriteLine (zahl1 - zahl2);
        }
        static void multiplication (int zahl1, int zahl2)
        { Console.WriteLine (zahl1 * zahl2);
        }
        static void division (int zahl1, int zahl2)
        {Console.WriteLine (zahl1 / zahl2);
        }
    }
}
