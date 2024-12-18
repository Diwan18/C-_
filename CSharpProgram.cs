using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int , long 'l', double 'D' , float 'F' , decimal 'M'


            //int a = 1;  
            //double b = 2.45;
            //long c = 1000000000000000000L;
            //float d = 8.0989F;
            //Console.WriteLine(  $"float = {d}, long= {c}" );







            

            // Arrays

            int[] A = { 1, 2, 3, 4, 5, 6  };

            foreach (int i in A)
            {
                Console.WriteLine(i);
            }


            // ArrayList

            ArrayList Ab = new ArrayList();

            Ab.Add(1);
            Ab.Add("Hello");

            foreach (var i in Ab) 
            {
                Console.WriteLine(i);
            }

            // List

            List<object> S = new List<object>();
            
            S.Add("Hello");
            S.Add("Hi");
            S.Add(21);
            foreach (var i in S) {
                Console.WriteLine(i);
            }

        // HashTable
            Hashtable DB = new Hashtable();
            DB.Add(1, "Hello");
            DB.Add(2, 43);
            DB.Add(3, 0.98);
            DB.Add("a", "ABC");
            DB.Add("B" , true);

            foreach (DictionaryEntry i in DB) 
            {
                Console.WriteLine($"{i.Key} , {i.Value}" );
                Console.WriteLine(i.Value);
            }


            //DB.Clear();
            DB.Remove(1);
            Console.WriteLine(DB[1]);
   
            //Dictionary
            Dictionary<int,int> data = new Dictionary<int, int>();

            data.Add(0, "Zero");
            data.Add(1, "One");

            foreach(var items in data) {
                Console.WriteLine(items);
            }

            for (int i = 0; i < data.Count; i++) {
                Console.WriteLine($"{data.Keys.ElementAt(i)}:{data.Values.ElementAt(i)}");


            }

        // Stack
            
            Stack stack = new Stack();
            stack.Push("Hi");
            stack.Push(09);
            stack.Push("H");
            stack.Push(80);

            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop()); 
            //Console.WriteLine(stack.Peek());

            while (stack.Count > 0) {
                Console.WriteLine(stack.Pop());
            }
        //Queue

            Queue queue = new Queue();
            queue.Enqueue(43);
            queue.Enqueue("Hello");
            queue.Enqueue(43.0987F);
            queue.Enqueue(true);


            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }




        }





    }
}
