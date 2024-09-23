/*
using System;
namespace CRabina
{
    class Person
    {
        private string location;
        private string name = "Rabina Chalaune";
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Name
        {
            get
            {
                return name.ToUpper();
            }
            set
            {
                if (value == "Rabina")
                    name = value;
            }
        }
    }
    class Properties
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            // set accessor will invoke 
            p.Name = "Sana";
            // set accessor will invoke 
            p.Location = "Bardiya";
            // get accessor will invoke 
            Console.WriteLine("Name: " + p.Name);
            // get accessor will invoke 
            Console.WriteLine("Location: " + p.Location);
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}*/