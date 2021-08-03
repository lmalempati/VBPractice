using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    interface IShape
    {
        int GetArea();
        int GetPerim(); 
    }
    abstract class Shape
    {
        public int sidecount;
        //public abstract double GetArea();
        public abstract int GetPerimeter();
    }

    class Square : Shape, IShape
    {
        int side;


        public Square(int n) => side = n;

        // GetArea method is required to avoid a compile-time error.
        public int GetArea() => side * side;
        //public override double GetArea() => side * side;

        //static void Main()
        //{
        //    var sq = new Square(12);
        //    Console.WriteLine($"Area of the square = {sq.GetArea()}");
        //}

        public override int GetPerimeter() => side * 4;

        int IShape.GetPerim()
        {
            return 4 * side;
        }
    }
    // Output: Area of the square = 144
}
