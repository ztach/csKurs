using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainClass
{
    public class Person
    {
        public int PersonId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Country { get; private set; }
        public int Age { get; private set; }

        public Person(int sPersonId, string sFirstName, string sLastName, string sCountry, int nAge)
        {
            PersonId = sPersonId;
            FirstName = sFirstName;
            LastName = sLastName;
            Country = sCountry;
            Age = nAge;
        }
    }
}
