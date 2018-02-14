using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPatternV2
{
    public partial class Form2 : Form
    {
        public Form2(ColorPicker colorPicker)
        {
            InitializeComponent();

            // subscribe to the observer
            colorPicker.ColorChagned += ColorChangedEventHandler;
        }

        private void ColorChangedEventHandler(ColorEventArgs e)
        {
            myPanel.BackColor = e.MyColor;
            myPanel.Refresh();
        }
    }
}
