using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Animal
    {
        public Animal()
        {
        

        }
        
        public string Name { get; set; }

        public int Legs { get; set; }

        public bool Tail { get; set; }  

        public bool SenseOfSmell { get; set; }


        public Animal(string name, int legs, bool tail, bool senseOfSmell)
        {
            Name = name;
            Legs = legs;
            Tail = tail;
            SenseOfSmell = senseOfSmell;
        
        
        }





    }
}
