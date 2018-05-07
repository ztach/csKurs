using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainClass;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace probaList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region  LISTA I WYDRUK
            Console.WriteLine("LISTA I WYDRUK");
            Console.WriteLine("");

            List<Person> oPersonList = new List<Person>
            {
                new Person(1, "Staszek", "Olejnik","Polska", 60),
                new Person(2, "Basia", "Olejnik","Polska", 50),
                new Person(3, "Józek", "Olejnik","Polska", 70)
            };

            foreach (var oPerson in oPersonList)
            {
                Console.WriteLine("Id osoby: " + oPerson.PersonId +
                                    "\nImię: " + oPerson.FirstName +
                                    "\nNazwisko: " + oPerson.LastName +
                                    "\nWiek: " + oPerson.Age + " lat.");
            }
            Person oFoundPerson = oPersonList.Find(oElement => oElement.Age == 50);

            Console.ReadKey();
            Console.Clear();

            #endregion

            #region ZAKUP I REZERWACJA BILETÓW DELEGATY

            Console.WriteLine("ZAKUP I REZERWACJA BILETÓW DELEGATY");
            Console.WriteLine("");

            EventHandlerClass oEventHandlerClass = new EventHandlerClass();
            Reservation oReservation = new Reservation();
            // rejestracja metody obsługi zdarzenia
            oReservation.ReservationDone += oEventHandlerClass.LogTransaction;
            oReservation.Reserve("Jan Kowalski", "Super film", "Rząd R, miejsce 10", 20.00);
            Console.WriteLine("--------------------------");
            oReservation.Reserve("Staszek Olejnik", "Też Super film", "Rząd A, miejsce 12", 40.00);
            
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region LISTA I LINQ
            Console.WriteLine("LISTA I LINQ");
            Console.WriteLine("");

            List<Person> oPersonLists = new List<Person>()
            {
                new Person(1, "Jan", "Kowalski","Polska", 26),
                new Person(2, "Anna", "Krawczyk","Kanada",25),
                new Person(3, "Krzysztof", "Nowak","USA", 24),
                new Person(4, "Katrzyna", "Lewandowska","Polska", 27),
                new Person(5, "Andrzej", "Wiśniewski","Japonia",28)
            };

            var oSelectedPersons = from Person oPerson in oPersonLists
                                   orderby oPerson.LastName
                                   select oPerson;

            var oSelectedPersonsA = from Person oPerson in oPersonLists
                                    where oPerson.Age > 24 && oPerson.FirstName == "Anna"
                                    select oPerson;

            int maxId = oPersonLists.Max(emp => emp.PersonId);

            foreach (Person emp in oSelectedPersonsA)
            {
                Console.WriteLine(" Person FirstName {0},\tLastName {1}" +
                    "\tAge {2}", emp.FirstName,
                    emp.LastName, emp.Age);
            }

            Console.WriteLine($"maxymalne Id = {maxId}");

            Console.ReadKey();
            Console.Clear();

            #endregion

            #region JSON serializacja
            Console.WriteLine("JSON I SERIALIZACJA");
            Console.WriteLine("");

            List<CZbiorSlowek> oSlowaList = new List<CZbiorSlowek>()
            {
                new CZbiorSlowek(1,"Osoba","Person"),
                new CZbiorSlowek(2, "Dom", "Home"),
                new CZbiorSlowek(3,"Praca","Job")
        };

            string json = JsonConvert.SerializeObject(oSlowaList);

            Console.WriteLine(json);

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region JSON DESERIALIZACJA

            Console.WriteLine("JSON I DESERIALIZACJA");
            Console.WriteLine("");

            List<CZbiorSlowek> entriesList = JsonConvert.DeserializeObject<List<CZbiorSlowek>>(json);

            Console.WriteLine("JSON ZDESERIALIZOWANY");

            foreach (CZbiorSlowek emp in entriesList)
            {
                Console.WriteLine(" Słowo Id = {0},\tSlowo = {1},\tZnaczenie = {2}", 
                    emp.SlowoId,emp.Slowo,emp.Znaczenie );
            }
            Console.ReadKey();
            Console.Clear();
            #endregion
            
            #region JSON I LINQ
            Console.WriteLine("JSON I LINQ");
            Console.WriteLine("");

            JArray wybraneSlowa = JArray.Parse(json);

            var oSelectedSlowa = (from sl in wybraneSlowa
                                  select sl).ToList();

            foreach (var item in oSelectedSlowa)
            {
                /*
                 Console.WriteLine("SlowoId = {0},\tSlowo = {1}" +
                    "\tZnaczenie = {2}", item.slowoId,);*/
                Console.WriteLine(item);
            }

            using (StreamWriter file = File.AppendText(@"slowniczek.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, oSelectedSlowa);
            }

            Console.WriteLine("naciśnij coś");
            object xx = "";
               xx = Console.ReadKey().Key;
            Console.WriteLine(xx.ToString());

            Console.WriteLine("");

            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            Console.WriteLine("");

            if (xx.Equals(ConsoleKey.Enter))
            {
                Console.WriteLine("ooo");
            }
            Console.WriteLine("");

            Console.WriteLine("naciśnij znowu");
            var x = Console.ReadKey();
            Console.WriteLine(x.Key);

            string w = (x.Key.Equals(ConsoleKey.X ) ? "tak":"nie" );
            Console.WriteLine(w);

            Console.ReadKey();
            Console.Clear();
            #endregion

        }
    }
}
