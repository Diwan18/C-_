using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicProject
{
    internal class C_Basic
    {
        public static void usingstring()
        {
            string Name = "Diwan";
            Console.WriteLine("Hello " + Name);
            Console.WriteLine(Name.Length);
        }

        public static void numbers()
        {
            Console.WriteLine(Math.Abs(-2333));
            //abs, sqrt , max , min ,Round , POW,
        }

        public static int cube(int num)
        {

            int numbers = num * num * num;

            return numbers;
        }




        static void Main(string[] args) {

            Random rand = new Random();
            Console.WriteLine(rand.Next(12233, 9999999)); 
            //Static Variable
            Song song  = new Song("a" , "b" , "c" , "d");
            Console.WriteLine(song.Title);
            Song Holiday = new Song("Holiday","GreenDay",200);
            Console.WriteLine(Holiday.Title);
            Console.WriteLine(Song.songcount);
            Song Kashmir = new Song("Kashmir","Led Zeppline",150);
            Console.WriteLine(Song.songcount);

            Song ABC = new Song("ABC", "CDE", 123);
            Console.WriteLine(ABC.getsongcount());

            Console.ReadLine();

            //Static Classes and methods

            Fixedmethods.sayhi("Diwan");
            

            Book book1 = new Book();
            book1.Title = "Harry Potter";
            book1.Author = "JK R";
            book1.Pages = 400;

            Console.WriteLine(book1.Title);


            //Exception Handling

            try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter a number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(num1 / num2);
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
                
            }


        Console.WriteLine(cube(2));
            //usingstring();

            //Console.Write("Enter your Name: ");
            //String Name = Console.ReadLine();
            //Console.WriteLine("Helo "+ Name);


            //array
            int[] numberarray = { 1, 2, 3, 4 };
            string[] stringarray = new string[3];
            stringarray[1] = "Apple";

            Console.WriteLine(numberarray[2]);
            Console.WriteLine(stringarray[1]);


            //Methods 


            //Console.Write("Enter the number :");
            //double num1=Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter a operator: ");
            //string op = Convert.ToString(Console.ReadLine());


            //Console.WriteLine("Enter the number :");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if (op == "+")
            //{
            //    Console.WriteLine(num1 + num2);
            //}
            //else if (op == "-")
            //{
            //    Console.WriteLine(num1 - num2);
            //}
            //else if (op == "*") { Console.WriteLine(num1 * num2); }
            //else
            //{
            //    Console.WriteLine("Enter the correct oprator");

            //}
            //class & Object
            //Constructor
            //Object Method
            //Getter and Setter 
            //static class Attribute




        }


    }
    }

