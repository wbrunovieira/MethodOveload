using System;
using System.Linq;

namespace methodOverLoadExecise
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(Add(7, 2));
          
            Console.WriteLine(Add(14.2m, 53.2m));
            
            Console.WriteLine(Add(4, 7, true));

            Console.WriteLine(Add(2, 4, 5, 6, 7));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        static string Add(int x, int y, bool isDolar)
        {
            int sum = x + y;
            if (isDolar == true)
                
            {
                if(x + y != 1)
                {
                    return $"{x + y} dollars";
                }

                else
                {
                    return $"{x + y} dollar";
                }
            }
            else
            {
                return (x + y).ToString();
            }
           
        }

        static int Add(params int[] arr)
        {
            return arr.Sum();
        }
    }
}
