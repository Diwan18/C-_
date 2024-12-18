using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_
{
    internal class ArrayProgram
    {
        public static void Main(string[] args)
        {
            int Max1, Max2;

            Console.WriteLine("The Array Elements are :");

            int[] arr = { 44, 55, 43, 89, 98, 100 };
            Console.WriteLine(arr.Length-1);
            for (int i = 0; i <= arr.Length-1; i++)
            {

                Console.WriteLine(arr[i]);
            }
            Max1 = Max2 = arr[0];

            for (int i = 0; i <= arr.Length-1; i++)
            {
                if (arr[i] > Max1)
                {

                    Max2 = Max1;
                    Max1 = arr[i];
                }
                else if (arr[i] > Max2)
                {
                    Max2 = arr[i];
                }              


            }
            Console.WriteLine("The First Largest Number:" + Max1);
            Console.WriteLine("The Second Largest Number:" + Max2);
        }
    }
}
