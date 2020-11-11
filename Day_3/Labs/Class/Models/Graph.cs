using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Class.Models
{
    public abstract class Graph
    {

        public Color Color;
        
        public static List<Graph> graphs = new List<Graph>();

        public Graph(Color color)
        {
            this.Color = color;
            graphs.Add(this);
        }

        public virtual void Draw() 
        {
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), Color.Name);
            Console.WriteLine("Draw");    
        }

        public static void AllDraw() {
            foreach (var graph in graphs)
            {
                graph.Draw();
            }
        }

    }
}
