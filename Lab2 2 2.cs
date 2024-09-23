using System;
using ClassAssemblyOne;
namespace ClassAssemblyTwo
{
    public class AssemblyTwoClassOne : AssemblyOneClassOne
    {
        public void MyMethod()
        {
            AssemblyTwoClassOne atwo = new AssemblyTwoClassOne();
            Console.WriteLine(atwo.age);
            //will throw error 
            // atwo.weight; 
        }
    }
}