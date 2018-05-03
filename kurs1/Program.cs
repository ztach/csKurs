using System;


namespace kurs1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                pobierzImie();
                podajWiek();

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("x - EXIT");
                string x = Console.ReadLine();
                if (x == "x")
                {
                    break;
                }

                czyscioch();
            }
        }

        private static void czyscioch()
        {
            Console.Clear();
        }

        private static void podajWiek()
        {
            Console.Write("PODAJ WIEK: ");

            bool czyInt = int.TryParse(Console.ReadLine(), out int wiek);
            if (!czyInt)
            {
                Console.WriteLine("to nie liczba");
            }
            else if (wiek > 17)
            {

                Console.WriteLine("masz " + wiek + " lat - idziemy na browara");
            }
            else
            {
                Console.WriteLine("masz " + wiek + " lat - idziemy na mleko");
            }
        }

        private static void pobierzImie()
        {
            Console.Write("PODAJ IMIĘ: ");
            string name = Console.ReadLine();
            Console.WriteLine("cześć " + name);
        }
    }
}
