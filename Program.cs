using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domashnoforloop
{
    class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.Write("*");

            }
            for (int i = 0; i<=n-2; i++)
           {
              Console.WriteLine("*{0}*", new string(' ',n-2));
            }
            for (int i = 1; i < n; i++)
            {
                Console.Write("*");
              
           } 
        }
    }
}
