using System;
using System.Collections.Generic;
using System.Text;

namespace House.Models
{
    public class Inhabitant
    {
        static int id;
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string PESEL { get; set; }
        public HouseModel HaveHouse { get; set; } = null;

        public Inhabitant(string surname, string phone, string pesel, HouseModel house = null)
        {
            ID = id++;
            Surname = surname;
            Phone = phone;
            PESEL = pesel;
            HaveHouse = house;
        }

        public bool IsOwner(HouseModel house)
        {
            if (HaveHouse == null)
            {
                Console.WriteLine("This person does not have home");
                return false;
            }
            else 
            {
                Console.WriteLine("This person does have home");
                HaveHouse = house;
                return true;
            }
        }

        public string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Id = {ID} name = {Surname} with pesel {PESEL} has home {HaveHouse.Address} ");
            return sb.ToString();
        }
    }
}
