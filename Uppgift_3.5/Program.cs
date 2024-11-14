using System;
namespace Uppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            int nr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in ett tal till");
            int nr1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Välj ett räknesätt (Skriv nummret)");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            int alt = int.Parse(Console.ReadLine());

            if (alt == 1)
            {
                nr = nr + nr1;
                Console.WriteLine("Detta är ditt tal:" + " " + nr);
            }
            else if (alt == 2)
            {
                nr = nr - nr1;
                Console.WriteLine("Detta är ditt tal:" + " " + nr);
            }
            else if (alt == 3)
            {
                nr = nr * nr1;
                Console.WriteLine("Detta är ditt tal:" + " " + nr);
            }
            else if (alt == 4)
            {
                nr = nr / nr1;
                Console.WriteLine("Detta är ditt tal:" + " " + nr);
            }
            
            Console.ReadLine();
        }
    }
}
