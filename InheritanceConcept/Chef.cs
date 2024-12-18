using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcept
{
    internal class Chef
    {
       public void makechicken() {
            Console.WriteLine("The chef is making chicken");
        }

        public void makechicken(string spicy)
        {
            Console.WriteLine("The chef is making spicy chicken" );
        }

        public void makesalad()
        {
            Console.WriteLine("The chef is making Salad");
        }
        public virtual void makesplDish()
        {
            Console.WriteLine("The chef is making chicken ribs");

        }
    }
}
