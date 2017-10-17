using System;

namespace Solid.LSP
{
    public class Rectangle
    {
        public virtual double Height { get; set; }

        public virtual double Width { get; set; }

        public double Area => Height * Width;
    }
}