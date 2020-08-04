using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        public int Fibonacci(int n)
        {
            if (n == 2 || n == 3)
                return 1;
            else
                return n;
            
            return Fibonacci(n-1) + Fibonacci(n-2);
        }
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("Olá Mundo!");

            System.Console.ReadKey();
        }
    }
}
