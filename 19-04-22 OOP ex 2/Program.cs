using System;

namespace _19_04_22_OOP_ex_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welk jaar is het");
            int year = Convert.ToInt32( Console.ReadLine());
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Het is een schrikkeljaar");
            }
            else
            {
                Console.WriteLine("Geen schrikkeljaar!");
            }
        }
    }
}
