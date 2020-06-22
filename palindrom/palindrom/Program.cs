using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            palindrom();
        }

        public static void palindrom()
        {
            
            int ile = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < ile; i++)
            {
                int count = 0;
                int odwrotnie = 0;
                string tekst = Console.ReadLine();
                int liczba = int.Parse(tekst);
                string tekst2 = "";
                
                do
                {
                    for (int j = tekst.Length - 1; j >= 0; j--)
                    {
                        tekst2 += tekst[j];
                    }
                    odwrotnie = int.Parse(tekst2);                    
                    if (odwrotnie == liczba)
                    {
                        
                        break;
                    }
                    liczba += odwrotnie;
                    count++;
                    tekst = liczba.ToString();
                    tekst2 = "";
                } while (true);
                Console.WriteLine($"Liczba {liczba} jest palindormem, wykonalo sie {count} powtorzen");
            }
        }
    }
}
