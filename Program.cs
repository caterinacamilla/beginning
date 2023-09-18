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
          
           //Berechne die Fibonacci Zahlen bis zu einer eingegebenen Zahl vm Nutzer
           //1+1 =2
           //1+2 =3

            Console.WriteLine("Bis zu welcher Zahl sollen die Fibonacci Zahlen ausgegeben werden?");
            int eingabe = Convert.ToInt32(Console.ReadLine());
            int fib1 = 1;
            int fib2 = 1;
            int ergebnis = 0;

            while(eingabe > (fib1+fib2))
            {
                ergebnis = fib1 + fib2;
                Console.WriteLine($"Ergebnis {fib1} + {fib2} = {ergebnis}");
                fib1 = fib2;
                fib2 = ergebnis;
            }
    }
}
}