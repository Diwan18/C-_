using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicProject
{
    internal class Palindrome
    {
        public static void Main(string[] args) {
            ////Palindrome Number
            int inputNum,
                temp,
                Sum = 0,
                Rem;

            //Console.Write("Enter a Number to check it ia a Palindrome: ");
            //inputNum = Convert.ToInt32(Console.ReadLine());
            inputNum = 121;
            temp = inputNum;

            while (inputNum > 0)
            {
                Rem = inputNum % 10;
                Sum = Sum * 10 + Rem;
                inputNum = inputNum / 10;
            }
            if (temp == Sum)
            {
                Console.WriteLine("It is a Palindrome");
            }
            else
            {
                Console.WriteLine("It is Not a Palindrome Number");
            }


            ////Prime Number
            bool isPrime = true;
            int pnum;
            pnum = 323;
            //Console.WriteLine("Enter a number: ");
            //pnum = int.Parse(Console.ReadLine());
            for (int i = 2; i < pnum; i++)
            {
                if (pnum % i == 0)
                {
                    isPrime = false;
                    Console.WriteLine("The given number is not prime");
                    break;
                }

            }

            if (isPrime)
            {
                Console.WriteLine("It is a prime");
            }

            //Fibonacci Series
            int I = 1, n = 10, t1 = 0, t2 = 1;
            Console.WriteLine("First " + n + " numbers series: ");
            while (I <= n)
            {
                Console.WriteLine(t1);
                int sum = t1 + t2;
                t1 = t2;
                t2 = sum;
                I++;
            }


        }
    }
}
