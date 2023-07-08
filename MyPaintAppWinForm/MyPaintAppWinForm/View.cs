using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaintAppWinForm
{
    public partial class View : Form
    {
        private bool Drag;
        private int Down;
        private int Up;

        public View()
        {
            InitializeComponent();           
        }

        private void TaskBarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Drag = true;
                Down = e.X;
                Up = e.Y;
            }
        }

        private void TaskBarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Drag = false;
            }
        }
        private void TaskBarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if(Drag)
            {
                Point tempPosition = new Point();
                tempPosition.X = Location.X + (e.X - Down);
                tempPosition.Y = Location.Y + (e.Y - Up);
                Location = tempPosition;
                tempPosition = default(Point);
            }
        }

        private void PencilButton_Click(object sender, EventArgs e)
        {
           
        }

        private void PicBox_Click(object sender, EventArgs e)
        {

        }

        private void ZoomInButton_Click(object sender, EventArgs e)
        {
            PicBox.Width += 100;
            PicBox.Height += 100;
        }

        private void ZoomOutButton_Click(object sender, EventArgs e)
        {
            PicBox.Width -= 100;
            PicBox.Height -= 100;
            Paint paint = new Paint();
           
        }
    }
}
