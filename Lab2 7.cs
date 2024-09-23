/*
using System;

namespace CRabina
{
    class Example
    {
        public int va1, va2;

        public Example(int a, int b)
        {
            va1 = a;
            va2 = b;
        }
        public Example()
        {

        }
        public static Example operator -(Example e)
        {
            e.va1 = -e.va1;
            e.va2 = -e.va2;
            return e;
        }

        public void PrintData()
        {
            Console.WriteLine("Value 1 : {0}", va1);
            Console.WriteLine("Value 2 : {0}", va2);
        }
    }

    internal class OperatorOverloadingDemo
    {
         static void Main(string[] args)
         {
             Example e1 = new Example(1, -2);
             e1.PrintData();
             Example e2 = new Example();
             e2 = -e1;
             e2.PrintData();
             Console.ReadKey();
         }
    }
}*/