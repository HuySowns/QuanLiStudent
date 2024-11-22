using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huyson
{
    abstract class Animal
    {
        public string Name { get; set; } // Thuộc tính Name được kế thừa
        public abstract void MakeSound(); // Phương thức trừu tượng
    }
}
