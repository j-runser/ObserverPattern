using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPatternV2
{
    public delegate void ColorChangedEventHandler(ColorEventArgs e);

    public class ColorPicker
    {
        public enum Colors {Black, Blue, Red, Green};

        public event ColorChangedEventHandler ColorChagned;
        private Color currentColor;

        public ColorPicker()
        {
            currentColor = Color.Black;
        }

        public void ChangeColor(Colors newColor)
        {
            switch(newColor)
            {
                case Colors.Red:
                    currentColor = Color.Red;
                    break;
                case Colors.Blue:
                    currentColor = Color.Blue;
                    break;
                case Colors.Green:
                    currentColor = Color.Green;
                    break;
                default:
                    currentColor = Color.Black;
                    break;
            }

            ColorChanged(new ColorEventArgs(currentColor));
        }

        protected virtual void ColorChanged(ColorEventArgs e)
        {
            ColorChangedEventHandler Handler = ColorChagned;
            if(Handler != null)
            {
                Handler(e);
            }
        }
        
    }

    public class ColorEventArgs : EventArgs
    {
        private Color myColor;

        public ColorEventArgs(Color color)
        {
            myColor = color;
        }


        public Color MyColor { get => myColor; set => MyColor = value; }
    }
}
