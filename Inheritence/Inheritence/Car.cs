using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Car
    {
        public int NumberOfDoors { get; set; }
        public string VinNumber { get; set; }
        public string NumberPlate { get; set; }
        public string Colour { get; set; }

        public Car()
        {
            
        }

        public virtual string CarSound()
        {
            return "Unable car, no engine";
        }
    }
}
