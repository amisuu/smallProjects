using System;
using System.Collections.Generic;
using System.Linq;

namespace Parzyste_nieparzyste
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Licz();
            Console.ReadKey();
        }

        public static void Licz() 
        {
            int countLoop = int.Parse(Console.ReadLine());
            string[] stringArray = { };                       

            for (int i = 0; i < countLoop; i++)
            {
                stringArray = Console.ReadLine().Split(" ");

                for (int j = 2; j < stringArray.Length; j+=2)
                {
                    Console.Write(stringArray[j] + " ");
                }

                for (int k = 1; k < stringArray.Length; k+=2)
                {
                    Console.Write(stringArray[k] + " ");
                }
                Console.WriteLine("\t");
            }     
        }
    }
}
