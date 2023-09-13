using System.Net.Mail;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Gebe mir deinen Namen!");
            string name = Console.ReadLine();

            Console.WriteLine("Sage mir wie alt du bist!");
            int age = Convert.ToInt16(Console.ReadLine());
            int alterin10 = age + 10;

            Console.WriteLine($"hello,   {name}!   Dein Alter ist {age} in 10 Jahren bin ich {alterin10}" );
            
        }
    }
}