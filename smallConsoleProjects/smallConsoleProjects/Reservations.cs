using System;
using System.Collections.Generic;
using System.Text;

namespace smallConsoleProjects
{
    public class Reservations
    {
        public Guid IDBarber { get; set; }
        public DateTime Data { get; set; }
        public decimal Cost { get; set; }
        public override string ToString()
        {
            return $"Numer fryzjera {IDBarber} - Cena {Cost}";
        }
    }
}
