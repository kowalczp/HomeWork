
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetlaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int licznik = 10;
            while (licznik > 0)
            {
                Console.WriteLine("Licznik=" + licznik);
                licznik--;
            }

            Console.WriteLine();

            licznik = 10;
            do
            {
                Console.WriteLine("Licznik (do while) = " + licznik);
                licznik--;
            } while (licznik > 0);

            Console.WriteLine();




            while (true)
            {
                Console.Write("Podaj liczbę >100 i podzielna przez 2: ");
                int liczba = Convert.ToInt32(Console.ReadLine());
                if (liczba > 100 && liczba % 2 == 0)
                {
                    Console.WriteLine("poprawna liczba");
                    break;
                }
                else
                {
                    Console.WriteLine("nieporawna liczba");
                }
            }

            Console.ReadKey();


        }
    }
}
