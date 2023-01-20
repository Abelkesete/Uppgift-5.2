using System;
namespace Uppgift_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            string [] tal = new string[3];
            

                tal[0] = "3";
                tal[1] = "4";
                Console.WriteLine("Skriv tredje tal: ");
                tal[2] = Console.ReadLine();

                Console.WriteLine($"{tal[0]}, {tal[1]} och {tal[2]} ");
        
        }
    }
}
