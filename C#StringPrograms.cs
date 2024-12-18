using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_
{
    internal class C_StringPrograms
    {
        private static object a;
        private static object convertTo;

        static void Main()
        {
            //Reverse a string
            string revstr = "", inputstr;
            Console.Write("Enter a string: ");
            inputstr = Console.ReadLine();
            inputstr=inputstr.ToLower();
            for(int i = inputstr.Length - 1; i >= 0; i--) 
            { 
            revstr += inputstr[i];
            }
            Console.WriteLine(revstr);
            if (inputstr == revstr)
            {
                Console.WriteLine("The given string is palindrome");
            }
            else
            {
                Console.WriteLine("It is not a Palindrome");
            }

            //Count No.of Words
            string str;
            int len = 0,
                count = 1;
            Console.Write("Enter a sentence: ");
            str = Console.ReadLine();

            while (len < str.Length ) {
                if (str[len] == ' ' || str[len] == '\n' || str[len] == '\t') 
                { 
                count++;
                }len++;
            }
            Console.WriteLine($"The String Contains: {count} words");

            //Find Occurrance

            string str1, str2, str3;
            int count1, count2, count3;

            Console.WriteLine("Enter a string: ");
            str1 = Console.ReadLine();            
            str2 = str1.ToLower();
            count1 = str2.Length;
            str3 = str2.Replace("h", "");

            count2 = str3.Length;

            count3 = count1 - count2;

            Console.WriteLine(str3);

            Console.WriteLine("The Word h occurs " + count3 + " times");

            // Sort Alphabetic Order
            char temp;
            string mystr;
            Console.Write("Enter a String: ");
            mystr= (Console.ReadLine());
            mystr = mystr.ToLower();

            char[] charstr = mystr.ToCharArray();
            for (int j = 1; j < charstr.Length; j++)
            {
                for (int i = 0; i < charstr.Length - 1; i++)
                {
                    if (charstr[i] > charstr[i + 1])
                    {
                        temp = charstr[i];
                        charstr[i] = charstr[i + 1];
                        charstr[i + 1] = temp;
                    }

                }
            
        }
            Console.WriteLine(charstr);



            // FindAll Elements
            int letter = 0, space = 0, num = 0, specialChar = 0;

            string test = "Hello, How are you doing?";

            // Iterate through each character in the string
            foreach (char ch in test)
            {
                if (char.IsLetter(ch))
                {
                    letter++;
                }
                else if (char.IsDigit(ch))
                {
                    num++;
                }
                else if (char.IsWhiteSpace(ch))
                {
                    space++;
                }
                else
                {
                    specialChar++;
                }
            }



        }


            }
}
