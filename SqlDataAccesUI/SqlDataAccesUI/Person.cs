using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccesUI
{
    public class Person
    {
        public int OrdersID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }

        public string FullInfo
        {
            get
            {
                // Alin Buzau (0722304315)
                return $"{ Name } { Location } ({ Phone })";
            }
        }

    }
}
