using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClass
{
    public class EventHandlerClass
    {
        public void LogTransaction(object oSender, EventArgs oEventArgs)
        {
            ReservationArgs oReservationArgs = oEventArgs as ReservationArgs;
            Console.WriteLine("Złożono rezerwację o następujących danych:" +
                "\nId: " + oReservationArgs.ReservationId +
                "\nImię i nazwisko: " + oReservationArgs.Name +
                "\nNazwa filmu: " + oReservationArgs.Movie +
                "\nMiejsce: " + oReservationArgs.Location +
                "\nCena biletu: " + string.Format("{0:C}",
                oReservationArgs.TicketPrice));
        }
    }
}
