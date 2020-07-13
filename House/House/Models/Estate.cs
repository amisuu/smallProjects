using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace House.Models
{
    public class Estate
    {
        public List<Inhabitant> Inhabitants = new List<Inhabitant>();
        public List<HouseModel> Houses = new List<HouseModel>();

        public Estate()
        {

        }

        List<T> list<T>()
        {
            if (typeof(T) == typeof(HouseModel))
            {
                return Houses as List<T>;
            }
            else if (typeof(T) == typeof(Inhabitant))
            {
                return Inhabitants as List<T>;
            }
            return null;
        }

        public bool AssignPeopleToHouse(int idInhabitant, int idHouse)
        {
            Inhabitant inhabitant = Inhabitants
                                    .Select(y => y)
                                    .Where(y => y.ID == idInhabitant)
                                    .FirstOrDefault(y => y.ID == idInhabitant);
            HouseModel house = Houses
                               .Select(y => y)
                               .Where(y => y.ID == idHouse)
                               .FirstOrDefault(y => y.ID == idHouse);
            return inhabitant.IsOwner(house);
        }

        public string ShowInfoAboutPeople()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"(ID) --> (Surname) --> (House)");
            for (int i = 0; i < Houses.Count; i++)
            {
                sb.Append($"{Inhabitants[i].ID} --> {Inhabitants[i].Surname} --> {Inhabitants[i].HaveHouse}");
            }
            return sb.ToString();
        }
    }
}
