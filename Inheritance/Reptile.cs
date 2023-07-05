using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public Reptile()
        {
        
        
        }
        
        
        public bool SharpTeeth { get; set; }

        public bool Scales { get; set;}

        public bool ColdBlooded { get; set; }

        public bool BackBone { get; set; }


        public Reptile(bool sharpTeeth, bool scales, bool coldBlooded, bool backBone)
        {
            SharpTeeth = sharpTeeth;
            Scales = scales;
            ColdBlooded = coldBlooded;
            BackBone = backBone;
        }
    }
}
