using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Class.Models
{
    public class Circle : Graph
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Circle(int X, int Y, Color color) : base(color) 
        {
            this.X = X;
            this.Y = Y;
        }

        public override void Draw()
        {
            base.Draw();
            Console.WriteLine($"X {X}: Y {Y}");
        }

    }
}
