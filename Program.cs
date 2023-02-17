using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            bool v = n % 4 == 0 && n % 100 != 0 ^ n % 400 == 0;
            if (v)
            {
                Console.WriteLine("YES");
                Console.WriteLine(n);
            }
            else if (n % 10 == 7 || n % 10 == 3)
            {
                n += 3;
                if (v)
                {
                    Console.WriteLine("NO");
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine("NO");
                    Console.WriteLine(n + 4);
                }
                
            }
            else if(n % 10 == 8 || n % 10 == 4)
            {
                n += 2;
                if (v)
                {
                    Console.WriteLine("NO");
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine("NO");
                    Console.WriteLine(n + 4);
                }
                
            }
            else if (n % 10 == 9 || n % 10 == 5 || n % 10 == 1)
            {
                n += 1;
                if (v)
                {
                    Console.WriteLine("NO");
                    Console.WriteLine(n);
                }
                else
                {
                    Console.WriteLine("NO");
                    Console.WriteLine(n + 4);
                }
            }
            else
            {
                Console.WriteLine("NO");
                Console.WriteLine(n + 4);
            }

        }
    }
}
