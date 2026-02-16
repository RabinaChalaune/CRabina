/*using System;
namespace CRabina 
{
    public delegate void RectangleDelete(double Width, double Height);
    public class MulticastDelegate
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine(@"Area is {0}", (Width * Height));
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine(@"Perimeter is {0}", (2 * (Width + Height)));
        }
        static void Main(string[] args)
        {
            MulticastDelegate rect = new MulticastDelegate();
            RectangleDelete rectDelegate = new RectangleDelete(rect.GetArea);
            //RectangleDelete rectDelegate = rect.GetArea;
            //binding a method with delegate object
            // In this example rectDelegate is a multicast delegate. You use += operator
            // to chain delegates together and -= operator to remove.
            rectDelegate += rect.GetPerimeter;
            rectDelegate(23.45, 67.89);
            Console.WriteLine();
            rectDelegate.Invoke(13.45, 76.89);
            Console.WriteLine();
            //Removing a method from delegate object
            rectDelegate -= rect.GetPerimeter;
            rectDelegate.Invoke(13.45, 76.89);
            Console.ReadLine();
        }
    }
}*/