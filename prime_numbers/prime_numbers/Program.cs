using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_numbers
{
    class Program
    {

        static void Main(string[] args)
        {

            string[] Number = args;
            foreach (string i in Number) // string Number consists of i
            {
                int x = int.Parse(i);
                bool isprime = true; 
                if (x == 1) 
                {
                    isprime = false;
                }
                for (int j = 2; j < x; j++) // initial j=2 because we should find prime numbers
                {
                    if (x % j == 0)
                    {
                        isprime = false;
                    }
                }
                if (isprime)
                {
                    Console.WriteLine(i);
                 }
            }
        }
    }   
}

