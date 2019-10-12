using System;

namespace Shapes
{
    internal class Circle : Shape
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * (Math.Pow(Radius, 2.0));
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It as a Radius of {Radius}");
        }
    }

}