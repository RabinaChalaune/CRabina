/*
 using System;

namespace LAB
{
    class BExample
    {
        public int number;
        public BExample()
        {
        }
        public BExample(int a)
        {
            number = a;
        }
        public static BExample operator +(BExample a, BExample b)
        {
            BExample c = new BExample();
            c.number = a.number + b.number;
            return c;
        }
        public void PrintNumber()
        {
            Console.WriteLine(number);
        }
    }
    internal class BinaryOperator
    {
      static void Main(string[] args)
         {

             BExample be1 = new BExample(56);
             BExample be2 = new BExample(100);
             BExample be3 = new BExample();
             be3 = be1 + be2;
             be3.PrintNumber();
            Console.ReadKey();
         } 
    }
}*/