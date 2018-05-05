using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClass
{
    public delegate void ReservationDelegate(object oSender, EventArgs oEventArgs);

    public class Reservation
    {
        public event ReservationDelegate ReservationDone;

        public void Reserve(string sName, string sMovie, string sLocation,
            double dTicketPrice)
        {
            ReservationArgs oReservationArgs = new ReservationArgs(sName, sMovie,
                sLocation, dTicketPrice);
            FireReservationEvent(oReservationArgs);
        }

        public void FireReservationEvent(EventArgs oEventArgs)
        {
            ReservationDone?.Invoke(this, oEventArgs);
        }
    }
}
