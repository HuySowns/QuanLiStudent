using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huyson
{
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} kêu: Gâu gâu");
        }
    }
}
