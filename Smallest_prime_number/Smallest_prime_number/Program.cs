using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace prime_numbers
{
    class Program
    {
        static bool isprime(int x)
        {
            if (x == 1)
            {
                return false;
            }
            for (int j = 2; j < x; j++)
            {
                if (x % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
            

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter sw = new StreamWriter("output.txt");
            string Number = sr.ReadLine();
            string[] array = Number.Split();
            int[] numbers = new int[array.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(array[i]);
            }
            int min = numbers[0];

            for (int j = 0; j < numbers.Length; j++)
            {
                    if (isprime(numbers[j]))
                         { 
                            if (numbers[j] < min)//если текущий элемент меньше минимального, то он становится минимальным.

                                min = numbers[j];
                            }

             }
            sw.WriteLine(min);
            sw.Close();
            sr.Close();
                        
            
                }
            }

        }
    