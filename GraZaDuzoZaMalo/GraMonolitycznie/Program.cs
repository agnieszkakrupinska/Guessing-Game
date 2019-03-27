using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraMonolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklaracja imienia
            Console.WriteLine("Witaj");
            Console.Write("Podaj swoje imie: ");
            string imie = Console.ReadLine();
            //Console.WriteLine($"Witaj {imie}!");

            //deklaracja nazwiska
            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();
            Console.WriteLine($"Witaj {imie} {nazwisko} :)");

            //deklaracja i konwertowanie wieku
            Console.WriteLine("Teraz podaj swoj wiek: ");
            int wiek = Convert.ToInt32(Console.ReadLine());

            if (wiek < 67)
            {
                Console.WriteLine("do emerytury zostalo ci {0} lat", 67 - wiek);
            }
            else
            {
                Console.WriteLine("Emeryt :)");
            }
            Console.ReadKey();
        }
    }
}
