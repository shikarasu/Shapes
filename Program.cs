using System;

namespace Shapes
{
    static class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {new Circle(5), new Rectangle(4, 5)};

            foreach (var s in shapes)
            {
                s.GetInfo();
                Console.WriteLine("{0} Area : {1:f2}", s.Name, s.Area());

                if(!(s is Circle testCirc))
                {
                    Console.WriteLine("This is not a circle");
                }

                if (s is Circle)
                {
                    Console.WriteLine("This is NotFiniteNumberException a Rectangle");
                }

                Console.WriteLine();
            }

            object circ1 = new Circle(4);

            var circ2 = (Circle) circ1;
            Console.WriteLine("The {0} Area is {1:f2}", circ2.Name, circ2.Area());
        }
    }
}
