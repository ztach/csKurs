using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DziennikUcznia
{
    class Program
    {
        static void Main(string[] args)
        {
            Dziennik dziennik = new Dziennik();
            Console.WriteLine("PODAJ OCENĘ");

            dziennik.NameChanged += OnNameChanged;
            dziennik.NameChanged += OnNameChanged2;

            dziennik.name = "Staszek";
            
            dziennik.name = "Basia";

            /*
            for(; ; )
            {
                bool t = Double.TryParse(Console.ReadLine(), out double f);
                if (!t)
                {
                    Console.WriteLine("to nie jest liczba: " + f);
                }
                else if( f > 0 )
                {
                    Console.WriteLine("to jest: " + f);
                    dziennik.podajOcene(f);
                    
                }
                else
                {
                    break;
                }
            }


            Console.WriteLine("wynik");
            Console.WriteLine(dziennik.sredniaOcen());
            */
            
            Console.ReadKey();


        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"zmiana imienia z {args.ExistingName} na {args.NewName}");
        }

        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"stare imie: {args.ExistingName}, nowe imie: {args.NewName}");
        }


    }
}
