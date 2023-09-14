using System.ComponentModel;

using System.Numerics;

using System.Security.Cryptography;

using System.Security.Cryptography.X509Certificates;
namespace HelloWorld
{
    class Program
    { static void Main(string[] args)
        { int Ergebnis = 1+1;
        Console.WriteLine(Ergebnis);
        Console.WriteLine("Höchstgrenze:");
int Max = Convert.ToInt32(Console.ReadLine());
long Fakultaet = 1; //Vorbelegung mit 1 ist wichtig!!!
for (long i = 1; i <= Max; i++)
{
Fakultaet *= i;
}
Console.WriteLine("{0}! = {1}", Max, Fakultaet);
}
}}