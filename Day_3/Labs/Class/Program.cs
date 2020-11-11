using Class.Models;
using System;
using System.Drawing;
using Point = Class.Models.Point;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Point(Color.Red);
            Graph circle = new Circle(10, 10, Color.Blue);
            Graph graph2 = new Point(Color.White);
            Graph.AllDraw();
        }
    }
}
