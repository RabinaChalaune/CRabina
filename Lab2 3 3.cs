using System;
using System.Xml.Linq;

namespace PartialClass
{
    public partial class MyClass
    {
        public void Display()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Roll : " + roll);
        }
    }
}
