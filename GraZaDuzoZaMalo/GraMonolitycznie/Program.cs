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
            /*
            Console.WriteLine("Witaj!");
            Console.Write("Podaj swoje imię: ");
            string x = Console.ReadLine();
            Console.WriteLine($"Witaj, {x}");
            */

            // 1. Komputer losuje liczbę
            Random generator = new Random();
            int wylosowana = generator.Next(1, 101);
            Console.WriteLine("Wylosowałem liczbę od 1 do 100. \n Odgadnij ją");

#if(DEBUG)
            Console.WriteLine(wylosowana);
#endif

            //wykonuj
            bool trafiono = false; //wartownik (zwany czasami flagą)
            do
            {
                #region Krok 2. Człowiek proponuje rozwiązanie
                Console.Write("Podaj swoją propozycję: ");
                string tekst = Console.ReadLine();
                if (tekst.ToLower() == "x")
                    break;

                int propozycja = 0;
                try
                {
                    propozycja = Convert.ToInt32(tekst);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Nie podano liczby!");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Liczba nie mieści się w rejestrze!");
                    continue;
                }

                Console.WriteLine($"Przyjąłem wartość {propozycja}");
                #endregion


                #region Krok 3. Komputer ocenia propozycję
                if (propozycja < wylosowana)
                    Console.WriteLine("za mało");
                else if (propozycja > wylosowana)
                    Console.WriteLine("za dużo");
                else
                {
                    Console.WriteLine("trafiono");
                    trafiono = true;
                }
                #endregion
            }
            while (!trafiono);
            //do momentu trafienia

            Console.WriteLine("Koniec gry");
        }
    }
}

/*using System;
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
            

            //potwierdzenie tożsamości
            Console.WriteLine($"Czy aby napewno nazywasz się {imie} {nazwisko}?");
            string potwierdzenie = Console.ReadLine();
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
                int wiek = Convert.ToInt32(Console.ReadLine());

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
}*/
