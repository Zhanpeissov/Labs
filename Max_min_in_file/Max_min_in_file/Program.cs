using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Max_min_in_file
{
    class Program
    {
        static void MaxMin()
        {
           
            StreamReader sr = new StreamReader(@"C:\Users\ljv\work\input.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\ljv\work\output.txt");
            string arr = sr.ReadLine();
            string[] massive = arr.Split();
            int[] numbers = new int[massive.Length];
            for (int i = 0; i < massive.Length; i++)
            {
                numbers[i] = int.Parse(massive[i]);
            }
            int min = numbers[0];
            int max = numbers[0];
            for (int i=0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)//если текущий элемент больше максимального, то он становится максимальным
                    max = numbers[i];
                
                if (numbers[i] < min)//если текущий элемент меньше минимального, то он становится минимальным.
               
                    min = numbers[i];
            }
            sw.WriteLine("maximum of numbers =" + max);
            sw.WriteLine("minimum of number="+ min);
            sr.Close();
            sw.Close();
        }
        static void Main(string[] args)
        {
            MaxMin();
        }
    
}
    }
