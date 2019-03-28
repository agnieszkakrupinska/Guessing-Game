using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace HelloConsoleVBDialog
{
    class Program
    {
        static void Main(string[] args)
        {
            Interaction.MsgBox("Hej, przedstaw się!", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Tytuł okienka");

            for (; ; )
            {


                string imie = Interaction.InputBox("Podaj imie", "Dane");
                if (imie == "")
                {
                    Interaction.MsgBox(" Nie podałeś imienia!");
                    Interaction.MsgBox(" Koniec!");
                    break;
                }
                else
                {
                    string nazwisko = Interaction.InputBox("Podaj nazwisko", "Dane");
                    if(nazwisko=="")
                    {
                        Interaction.MsgBox(" Nie podałeś nazwiska!");
                        Interaction.MsgBox(" Koniec!");
                        break;
                    }
                    else
                    {
                    
                    Interaction.MsgBox("Witaj " + imie + " " + nazwisko);

                    int wiek = Convert.ToInt32(Interaction.InputBox("Podaj swoj wiek", "Dane"));
                        /*if (wiek == )
                        {
                            Interaction.MsgBox("Nie podałeś wieku!");
                            Interaction.MsgBox("Koniec!");
                            break;
                        }
                        else
                        {*/

                       

                            if (wiek > 0 && wiek < 67)
                            {
                             Interaction.MsgBox("do emerytury zostalo ci " + (67 - wiek) + " lat", MsgBoxStyle.OkOnly | MsgBoxStyle.Information, "Emerytura");
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
                        break;
                    
                        //}
                    }
                }

            }
        }
    }
}
