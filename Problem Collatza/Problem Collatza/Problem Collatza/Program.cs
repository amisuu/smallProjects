using System;

namespace Problem_Collatza
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                int p = int.Parse(Console.ReadLine());
                Console.WriteLine(CollatzProblem(p, 0));
                Console.ReadKey();
            }
        }

        public static int CollatzProblem(int p, int n)
        {           
            //int result = 0;

            if (p == 1)
            {
                return n;
            }
            else
            {
                if (p % 2 == 0)
                {
                    return CollatzProblem(p / 2, ++n);
                }
                else if (p % 2 == 1)
                {
                    return CollatzProblem(3 * p + 1, ++n);
                }
            }          
        }
    }
}
