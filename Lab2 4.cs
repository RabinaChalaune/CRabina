/*
using System;
namespace CRabina
{
    class GrandFather
    {
        public void land()
        {
            Console.WriteLine("GrandFather's land");
        }
    }
    class Father : GrandFather
    {
        public void home()
        {
            Console.WriteLine("Father's home");
        }
        public void Car()
        {
            Console.WriteLine("Father's Car");
        }
    }
    // Inherit /derived / extends 
    class Son : Father
    {
        public Son()
        {
            Console.WriteLine("Son...");
        }
        public void mobile()
        {
            Console.WriteLine("Son's mobile");
        }
    }
    class Daughter : Father
    {
        // Daughter constructor 
        public Daughter()
        {
            Console.WriteLine("Daughter...");
        }
        public void purse()
        {
            Console.WriteLine("Daughter's purse");
        }
    }
    public class Inheritance
    {
        public static void Main(String[] args)
        {
            // Son object 
            Son s = new Son();
            s.land();// Grand father method 
            s.Car(); // Father method 
            s.home();// Father method 
            s.mobile();// son method 
            Daughter d = new Daughter(); // Daughter object 
            d.land();// Grand father method 
            d.Car(); // Father method 
            d.home();// Father method 
            d.purse();// son method 
            Console.ReadLine();
        }
    }
}*/