using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DziennikUcznia
{
    class Dziennik
    {
        List<double> oceny = new List<double>();

        public void podajOcene(double ocena)
        {
            oceny.Add(ocena);
        }

        public double sredniaOcen()
        {
            double sumaOcen = 0;

            foreach (var o in oceny)
            {
                sumaOcen += o;
            }
            return sumaOcen / oceny.Count();
        }


    }
}
