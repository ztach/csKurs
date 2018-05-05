using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        public string PersonId { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        public Person(string sPersonId, string sFirstName, string sLastName, int nAge)
        {
            PersonId = sPersonId;
            FirstName = sFirstName;
            LastName = sLastName;
            Age = nAge;
        }
    }
}
