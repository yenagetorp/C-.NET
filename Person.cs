using System.Collections.Generic;

namespace Övning16WinFormsVersion1
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string SSN { get; set; }
        public List<string> PhoneNumbers { get; set; }
        //* //
        public List<Address> Addresses{get; set;}

        public Person()
        {
            PhoneNumbers = new List<string>();
            Addresses = new List<Address>();
        }
       
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
