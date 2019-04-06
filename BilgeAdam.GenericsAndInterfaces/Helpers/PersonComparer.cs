using System.Collections.Generic;

namespace BilgeAdam.GenericsAndInterfaces.Helpers
{
    class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            return x.BirthDate == y.BirthDate;
        }

        public int GetHashCode(Person obj)
        {
            return obj.FirstName.GetHashCode() + obj.LastName.GetHashCode();
        }
    }
}
