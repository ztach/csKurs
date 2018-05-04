using System;
using System.Collections.Generic;


namespace DziennikUcznia
{
    /// <summary>
    /// klasa Dziennik
    /// obsługuje listę ocen wprowadzanych dla jednego ucznia
    /// i oblicza jego średnią
    /// </summary>
    public class Dziennik
    {
  
        
        public Dziennik()
        {
            oceny = new List<double>();
            _name = "Józek";
        }
        private string _name;

        public string name
        {
            get
            {
                return name.ToUpper();
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }
                }
                _name = value;
            }
        }

        public event NameChangedDelegate NameChanged;

        /// <summary>
        /// lista ocen
        /// </summary>
        List<double> oceny;

        /// <summary>
        /// podajesz oceny dla ucznia
        /// </summary>
        /// <param name="ocena"></param>
        public void podajOcene(double ocena)
        {
            oceny.Add(ocena);
        }

        /// <summary>
        /// obliczam średnią ocen
        /// </summary>
        /// <returns></returns>
        public double sredniaOcen()
        {
            double sumaOcen = 0;

            foreach (var o in oceny)
            {
                sumaOcen += o;
            }
            return sumaOcen / oceny.Count;
        }


    }
}
