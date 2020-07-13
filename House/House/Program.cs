using House.Models;
using System;
using System.Collections.Generic;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            Doors doors = new Doors(70);
            Inhabitant homie = new Inhabitant("John Flitch","90930293", "92832832");
            HouseModel house = new HouseModel("malinowa 2",90,2);
            Console.ReadKey();
        }
    }
}
