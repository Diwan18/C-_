using System;
using System.Collections.Generic;


namespace BasicC_
{
    internal class C_InterviewProgram
    {

        public static void Main(string[] args) {


            //Sort the below List based on Length of the string
            List<string> L = new List<string> { "Java", "C_sharp", "JavaScript", "Python" };


            //var sortedLangReverse = L.OrderByDescending(x => x.Length).ToList();

            //L.Sort((x,y)=> x.Length.CompareTo(y.Length));

            //L.Sort((x, y) => y.Length.CompareTo(x.Length));

            L.Sort((a, b) => a.Length.CompareTo(b.Length));

            for (int i = 0; i < L.Count; i++) {

                Console.WriteLine(L[i]);
            }

            //foreach (string Lang in sortedLangReverse)
            //{
            //    Console.WriteLine(Lang);
            //}

            // Find the Third smallest number in the array

            int[] A = { 2, 555, 56, 34, 123, 67, 32 };

            Array.Sort(A(y,x)=> y.CompareTo(x);
            foreach (int i in A)
            {
                Console.WriteLine(i);
            }  Console.WriteLine($"The Third Smallest Number : { A[3]}");

            // Print 1 to 100 and 99 to 1 using one loop
           
            for (int i = 1; i < 200; i++) {

                int Number = (i <= 100) ? i : 200 - i;
                Console.WriteLine(Number);
               
                }
            
            }

        }


    }

