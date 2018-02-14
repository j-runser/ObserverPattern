using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternV2
{
    public class Thing
    {
        private int size;
        private Color color;

        public Thing(int size, Color color)
        {
            this.size = size;
            this.color = color;
        }

        public int Size { get => size; set => size = value; }
        public Color Color { get => color; set => color = value; }
    }
}
