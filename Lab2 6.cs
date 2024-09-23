/*
using System;
namespace CRabina
{
    public class Constructor
    {

        //Default Constructor
        int a, b;
        public Constructor()
        {
            a = 200;
            b = 300;
            Console.WriteLine("This is Default Constructor");
        }

        //parameterized constructor
        public Constructor(int x, int y)
        {
            a = x;
            b = y;
            Console.WriteLine("This is parameterized Constructor");
        }

        //Copy Constructor
        public Constructor(Constructor c)
        {
            a = c.a;
            b = c.b;
            Console.WriteLine("This is Copy Constructor");
        }

        //Static Constructor
        static Constructor()
        {
            Console.WriteLine("This is static constructor");
        }

        //Destructor
        ~Constructor()
        {
            Console.WriteLine("I am destroyed");
            Console.ReadKey();
        }

        //Deconstructor
        public void Deconstruct(out int p, out int q)
        {
            p = a;
            q = b;
        }
         static void Main(string[] args)
                {

                    //default
                    Constructor d = new Constructor();
                    Console.WriteLine(d.a);
                    Console.WriteLine(d.b);

                    //parameterized
                    Constructor c = new Constructor(450, 120);
                    Console.WriteLine(c.a);
                    Console.WriteLine(c.b);

                    //copy 
                    Constructor cp = new Constructor(c);
                    Console.WriteLine(cp.a);
                    Console.WriteLine(cp.b);

                    Console.WriteLine("This is demo for constructor");
                    Console.ReadKey();
                } 
    }
}*/
