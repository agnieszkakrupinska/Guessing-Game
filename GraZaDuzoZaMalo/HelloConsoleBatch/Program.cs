using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloConsoleBatch
{
    class Program
    {
        static void Main(string[] args)
        {
          
            //deklaracja imienia
            Console.WriteLine("Witaj");
            Console.Write("Podaj swoje imie: ");
            string imie = args[0];
            //Console.WriteLine($"Witaj {imie}!");

            //deklaracja nazwiska
            Console.Write("Podaj nazwisko: ");
            string nazwisko = args[1];


            //potwierdzenie tożsamości
            Console.WriteLine($"Czy aby napewno nazywasz się {imie} {nazwisko}?");
            string potwierdzenie = args[2];
            if (potwierdzenie == "nie")
            {
                Console.WriteLine("Powtórz jeszcze raz wpisywanie danych :(");
                Console.ReadKey();
            }
            else if (potwierdzenie == "tak")
            {
                Console.WriteLine($"Witaj {imie} {nazwisko} :)");

                //deklaracja i konwertowanie wieku
                Console.WriteLine("Teraz podaj swoj wiek: ");
                int wiek = Convert.ToInt32(args[3]);

                if (wiek > 0 && wiek < 67)
                {
                    Console.WriteLine("do emerytury zostalo ci {0} lat", 67 - wiek);
                }
                else if (wiek < 0)
                {
                    Console.WriteLine("Podano błędne dane!");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Emeryt :)");
                }
                Console.ReadKey();

            }
            else
                Console.WriteLine("Błędne dane!!");
            Console.ReadKey();
        }
    }
}
