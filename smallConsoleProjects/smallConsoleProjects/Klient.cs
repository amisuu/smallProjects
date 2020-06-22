using System;
using System.Collections.Generic;
using System.Text;

namespace smallConsoleProjects
{
    public class Klient
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Status Status { get; set; }
        public decimal PriceDiscount()
        {
            return (1 - (int)Status/100.0m);
        }
    }
}
