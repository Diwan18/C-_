using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceConcept
{
    internal class ItalianChef : Chef 
    {
        public override void makesplDish()
        {
            Console.WriteLine("The italian chef is making ChickenPasta");
        }
    }
}
