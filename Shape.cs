using System;

namespace Shapes
{
    abstract class Shape
    {
        public string Name { get; protected set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"This is {Name}");
        }

        public abstract double Area();
    }
}