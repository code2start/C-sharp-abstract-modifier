using System;

namespace abstract_modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //var s = new Square(12);
            //Console.WriteLine($"Area of square = {s.GetArea()}");
            var o = new DerviedClass();
            o.F();
            Console.WriteLine($"x = {o.X}, y = {o.Y}");

        }
    }
}
