using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicProject
{
    internal class Armstrong
    {
        public static void Main(string[] args)
        {
            //Armstrong Number
            int num, temp, sum = 0, rem;

            //Console.Write("Enter a Three Digit Number to check it is Armstrong: ");
            //num = Convert.ToInt32(Console.ReadLine());

            num = 253;
            temp = num;

            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem * rem * rem);
                num = num / 10;

            }
            if (temp == sum)
            {
                Console.WriteLine("It is a Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not a Armstrong Number");
            }




           
        }
    }
}