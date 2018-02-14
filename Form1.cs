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
    public partial class Form1 : Form
    {
        ColorPicker colorPicker;

        // observers
        Form2 formA;
        Form2 formB;
        Form2 formC;

        public Form1()
        {
            InitializeComponent();
            
            // observable 
            colorPicker = new ColorPicker();

            formA = new Form2(colorPicker);
            formB = new Form2(colorPicker);
            formC = new Form2(colorPicker);

            formA.Show();
            formB.Show();
            formC.Show();
        }

        private void cmbBox_color_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbBox_color.SelectedIndex)
            {
                case 0:
                    colorPicker.ChangeColor(ColorPicker.Colors.Black);
                    break;
                case 1:
                    colorPicker.ChangeColor(ColorPicker.Colors.Red);
                    break;
                case 2:
                    colorPicker.ChangeColor(ColorPicker.Colors.Blue);
                    break;
                default:
                    colorPicker.ChangeColor(ColorPicker.Colors.Green);
                    break;
            }
        }
    }
}
