using System;
using System.Collections.Generic;
using System.Text;

namespace House.Models
{
    public class HouseModel
    {
        static int id;
        public int ID { get; set; }
        public string Address { get; set; }
        public int SizeMkw { get; set; }
        public int Capacity { get; set; }

        public List<Doors> Doors = new List<Doors>();
        public List<Inhabitant> InhabitansInHouse = new List<Inhabitant>();

        public HouseModel(string address, int size, int capacity)
        {
            ID = id++;
            Address = address;
            SizeMkw = size;
            Capacity = SizeMkw / 15;
        }

        List<T> list<T>()
        {
            if (typeof(T) == typeof(Doors))
            {
                return Doors as List<T>;
            }
            else if (typeof(T) == typeof(Inhabitant))
            {
                return InhabitansInHouse as List<T>;
            }
            return null;
        }
        public bool Add<T>(T objectToAdd)
        {
            var temp = list<T>();
            if (temp == null && temp.Contains(objectToAdd))
            {
                return false;
            }
            else if (temp.Capacity >= Capacity)
            {
                Console.WriteLine("too many people in house");
            }
            temp.Add(objectToAdd);
            Console.WriteLine($"Object {objectToAdd} added to {temp}");
            return true;
        }

        public bool Delete<T>(T objectToRemove)
        {
            var temp = list<T>();
            if (!temp.Contains(objectToRemove))
            {
                return false;
            }
            temp.Remove(objectToRemove);
            return true;
        }

        public string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var info in InhabitansInHouse)
            {
                sb.Append($"{info.Surname} with pesel {info.PESEL} is in {Address}");
            }
            return sb.ToString();
        }
    }
}
