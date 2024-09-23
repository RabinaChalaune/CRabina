// Write a C# program to create virtual method in C#.
/*using System;
namespace CRabina
{
    class Shape 
    {
        public double length = 0.0;
        public double width = 0.0;
        public double radius = 0.0;

        public Shape(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public Shape(double radius)
        {
            this.radius = radius;
        }

        public virtual void Area()
        {
            double area = 0.0;
            area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area of Shape is :{0:0.00} ", area);
        }
    }

    class Rectangle : Shape
    {

        public Rectangle(double length, double width) : base(length, width)
        {
        }

        public override void Area()
        {
            double area = 0.0;
            area = length * width;
            Console.WriteLine("Area of Rectangle is :{0:0.00} ", area);
        }
    }
    class Circle : Shape
    {
        public Circle(double radius)
        : base(radius)
        {
        }
    }
    internal class VirtualMethod
    {
         static void Main(string[] args)
        {
            double length, width, radius = 0.0;
            Console.WriteLine("Enter the Length");
            length = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Width");
            width = Double.Parse(Console.ReadLine());
            Rectangle objRectangle = new Rectangle(length, width);
            objRectangle.Area();

            Console.WriteLine("Enter the Radius");
            radius = Double.Parse(Console.ReadLine());
            Circle objCircle = new Circle(radius);
            objCircle.Area();
            Console.Read();
        }
    }
}
*/