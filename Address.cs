using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning16WinFormsVersion1
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }

        public override string ToString()
        {
            return $"{Street}, {City}";
        }
    }

}
