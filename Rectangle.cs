using System;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        private double Length { get; set; }
        private double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Name = "Rectangle";
            Length = Length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"It has a length of {Length} and Width of {Width}");
        }
    }
}