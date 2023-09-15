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

            string zahl1 = "16";

            string zahl2 = "32";
            switch(operators)
            {
                case "+":
                    Addition(zahl1,zahl2);
                    break;
                case "-":
                    substraction(zahl1,zahl2);
                    break;
                case "*":
                    multiplication(zahl1,zahl2);
                    break;
                case "/":
                    division(zahl1, zahl2);
                    break;
                default:
                    Console.WriteLine ("unknown Operator"); 
                    break;
            }
        }

        static int AdditionwithReturn (string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32 (zahl1);
            int numero2 = Convert.ToInt32 (zahl2);
        
            return numero1 + numero2;
        }
        static void Addition (string zahl1, string zahl2)
        
        { 
            int numero1 = Convert.ToInt32 (zahl1);
            int numero2 = Convert.ToInt32 (zahl2);
            Console.WriteLine (numero1 + numero2);
           
        }
        static void substraction (string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32 (zahl1);
            int numero2 = Convert.ToInt32 (zahl2);
            Console.WriteLine (numero1 - numero2);
        }
        static void multiplication (string zahl1, string zahl2)
        { 
            int numero1 = Convert.ToInt32 (zahl1);
            int numero2 = Convert.ToInt32 (zahl2);
            Console.WriteLine (numero1* numero2);
        }
        static void division (string zahl1, string zahl2)
        {
            int numero1 = Convert.ToInt32 (zahl1);
            int numero2 = Convert.ToInt32 (zahl2);
            Console.WriteLine (numero1 / numero2);
        }
    }
}
