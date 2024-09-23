using System;

namespace PartialClass
{
    public partial class MyClass
    {
        private string name;
        private int roll;

        public MyClass(string n, int r)
        {
            this.name = n;
            this.roll = r;
        }
    }
}
