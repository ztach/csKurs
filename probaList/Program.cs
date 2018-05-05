using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainClass;

namespace probaList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Person> oPersonList = new List<Person>
            {
                new Person(1, "Staszek", "Olejnik", 60),
                new Person(2, "Basia", "Olejnik", 50),
                new Person(3, "Józek", "Olejnik", 70)
            };


            foreach (var oPerson in oPersonList)
            {
                // Console.WriteLine($"{oPerson.FirstName}, {oPerson.LastName}");
                Console.WriteLine("Id osoby: " + oPerson.PersonId +
                                    "\nImię: " + oPerson.FirstName +
                                    "\nNazwisko: " + oPerson.LastName +
                                    "\nWiek: " + oPerson.Age + " lat.");
            }

            Console.ReadKey();

            Person oFoundPerson = oPersonList.Find(oElement => oElement.Age == 50);

            Console.ReadKey();
      
        
        
            MainClass.EventHandlerClass oEventHandlerClass = new MainClass.EventHandlerClass();
            Reservation oReservation = new Reservation();
            // rejestracja metody obsługi zdarzenia
            oReservation.ReservationDone += oEventHandlerClass.LogTransaction;
            oReservation.Reserve("Jan Kowalski", "Super film", "Rząd R, miejsce 10", 20.00);
            Console.WriteLine("--------------------------");
            oReservation.Reserve("Staszek Olejnik", "Też Super film", "Rząd A, miejsce 12", 40.00);


            Console.ReadKey();
            
        }
    }
}
