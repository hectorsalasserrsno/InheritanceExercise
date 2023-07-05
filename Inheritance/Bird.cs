using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public Bird() 
        {
        
        
        }
        
        public bool Peak { get; set; }

        public int Wings { get; set; }

        public bool Feathers { get; set; }

        public bool Sing { get; set; }

        public Bird(bool peak, int wings, bool feathers, bool sing) 
        {
            Peak = peak;
            Wings = wings;
            Feathers = feathers;
            Sing = sing;    
        }
    }
}
