using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex_numbers1
{
    class Complex
    {

        public int a, b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static int GCD(int a, int b)
        {
            while (a != 0 && b != 0)
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            return (a | b);
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
        public static Complex operator +(Complex n1, Complex n2)
        {
            int a = n1.a * n2.b + n2.a *n1.b;
            int b = n1.b * n2.b;
            int c = GCD(a, b);
            a = a / c;
            b = b / c;
            Complex Answer = new Complex(a, b);
            return Answer;
        }
        public static Complex operator -(Complex n1, Complex n2)
        {
            int a = n1.a * n2.b - n2.a * n1.b;
            int b = n1.b * n2.b;
            int c = GCD(a, b);
            a = a / c;
            b = b / c;
            Complex Answer = new Complex(a, b);
            return Answer;
        }
        public static Complex operator *(Complex n1, Complex n2)
        {
            int a = n1.a * n2.a;
            int b = n1.b * n2.b;
            int c = GCD(a, b);
            a = a / c;
            b = b / c;
            Complex Answer = new Complex(a, b);
            return Answer;
        }
        public static Complex operator /(Complex n1, Complex n2)
        {
            int a = n1.a * n2.b;
            int b = n1.b * n2.a;
            int c = GCD(a, b);
            a = a / c;
            b = b / c;
            Complex Answer = new Complex(a, b);
            return Answer;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // insert values  
            string[] arr = s.Split(); //divide them by the space
            Complex sum = new Complex(0, 0); //create a new complex with zero atributes 
            foreach (string ss in arr) //rewrite values from array to string 
            {
                string[] t = ss.Split('/'); //divide them by /
                Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                if (sum.a == 0 & sum.b == 0)
                {
                    sum = p;
                }
                else
                {
                    sum = sum + p;
                }
            }
            Complex sub = new Complex(0, 0); //create a new complex with zero atributes 
            foreach (string ss in arr) //rewrite values from array to string 
            {
                string[] t = ss.Split('/'); //divide them by /
                Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                if (sub.a == 0 & sub.b == 0)
                {
                    sub = p;
                }
                else
                {
                    sub = sub - p;
                }
            }
            Complex mul = new Complex(0, 0);
            foreach (string ss in arr)
            {
                string[] t = ss.Split('/');
                Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                if (mul.a == 0 & mul.b == 0)
                {
                    mul = p;
                }
                else
                {
                    mul = mul * p;
                }
            }

            Complex div = new Complex(0, 0);
            foreach (string ss in arr)
            {
                string[] t = ss.Split('/');
                Complex p = new Complex(int.Parse(t[0]), int.Parse(t[1]));
                if (div.a == 0 & div.b == 0)
                {
                    div = p;
                }
                else
                {
                    div = div/p;
                }
            }
            //show results 
            //we rewrited ToString, so we can just write names of operations(complex)
            Console.WriteLine(sum+" "+ "addition of two numbers");
            Console.WriteLine(sub+" "+ "substruction of two numbers");
            Console.WriteLine(mul+" "+ "multiplication of two numbers");
            Console.WriteLine(div+" "+ "division of two numbers");

            Console.ReadKey();


        }
     }
 }

