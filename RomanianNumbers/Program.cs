using System;
using System.Collections.Generic;

namespace RomanianNumbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string numberString = Console.ReadLine();
            
            Console.WriteLine(SplitRomanian(numberString));
            Console.ReadKey();
        }

        public static Dictionary<char, int> listInRomanian = new Dictionary<char, int>(){
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };
        
        public static int SplitRomanian(string roman)
        {
            var listOfRoman = new List<char>();
            Numbers model = new Numbers();
            int number = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                listOfRoman[i] = char.Parse(roman);
            }

            foreach (var letter in listOfRoman)
            {
                switch (letter)
	            {   
                    case 'I':
                            number += 1;
                            model.numberOfNumbers++;
                        break;
                    case 'V':
                            number += 5;
                            model.numberOfNumbers++;
                        break;
                    case 'X':
                            number += 10;
                            model.numberOfNumbers++;
                        break;
                    case 'L':
                            number += 50;
                            model.numberOfNumbers++;
                        break;
                    case 'C':
                            number += 100;
                            model.numberOfNumbers++;
                        break;
                    case 'D':
                            number += 500;
                            model.numberOfNumbers++;
                        break;
                    case 'M':
                            number += 1000;
                            model.numberOfNumbers++;
                        break;
		            default:
                        break;
	            }
            }
            return number;
        }
        
    }
}
