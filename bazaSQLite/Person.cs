using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bazaSQLite
{
    public class Person
    {
        public int PersonId { get; private set; }
        public string PersonName { get; private set; }
        public string PersonLastName { get; private set; }
        public int PersonAge { get; private set; }

        public Person(int sPersonId, string sFirstName, string sLastName, int nAge)
        {
            PersonId = sPersonId;
            PersonName = sFirstName;
            PersonLastName = sLastName;
            PersonAge = nAge;
        }
    }
}
