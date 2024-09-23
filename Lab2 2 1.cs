using System;
namespace ClassAssemblyOne
{
    public class AssemblyOneClassOne
    {
        protected internal int age;
        internal double weight;
    }
    public class AssemblyOneClassTwo
    {
        public void MyData()
        {
            AssemblyOneClassOne cone = new AssemblyOneClassOne();
            cone.age = 50;
            cone.weight = 60.5;
            Console.WriteLine("This is my Data");
            Console.WriteLine(cone.age);
            Console.WriteLine(cone.weight);
        }
        public void PrintData()
        {
        }
    }
}