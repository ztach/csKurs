using System;


namespace kurs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("PODAJ IMIĘ: ");
            string name = Console.ReadLine();
            Console.WriteLine("cześć " + name);

            Console.Write("PODAJ WIEK: ");
            
            bool czyInt = int.TryParse(Console.ReadLine(), out int wiek);
            if (!czyInt)
            {
                Console.WriteLine("to nie liczba");
            }
            else if(wiek > 17)
            {

                Console.WriteLine("masz " + wiek + " lat - idziemy na browara");
            }
            else
            {
                Console.WriteLine("masz " + wiek + " lat - idziemy na mleko");
            }
            

            Console.Write("ENTER");
            Console.ReadLine();
        }
    }
}
