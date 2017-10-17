using System;

using IO = System.Console;

namespace Solid.LSP
{
    class Program
    {
        static void Calculate(Rectangle rectangle)
        {
            IO.WriteLine("Rectangle Area Calculation");
            IO.WriteLine($"{rectangle.Height} x {rectangle.Width}");
            IO.WriteLine($"Area: {rectangle.Area}");
        }

        static void Main(string[] args)
        {
            Calculate(new Square { Height = 10, Width = 5 });
        }
    }
}
