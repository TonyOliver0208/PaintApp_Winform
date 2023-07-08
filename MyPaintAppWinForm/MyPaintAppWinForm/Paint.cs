using CustomControls.RJControls;
using MyPersonalCustomizeButton;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaintAppWinForm
{
    public partial class Paint : Form
    {
        private bool Drag;
        private int Down;
        private int Up;
        private bool isMouse = false;
        private bool isDrawn = false;
        private int index = 0;
        private int penSize = 3;
        private Point startPoint;
        private bool isDrawingLine = false;
        int x,y;
        private Point endPoint;
        private Rectangle rectangle;
        private List<Point> points = new List<Point>();
        private readonly View viewForm = new View
        {
            TopLevel = false
        };
        private ArrayPoints arrayPoints = new ArrayPoints(2);
        private List<MyPersonalButton> toolButtons = new List<MyPersonalButton>();
        private List<RJButton> sizeButtons = new List<RJButton>();
        private Bitmap map = new Bitmap(100, 100);
        private Graphics graphics;
        private Pen pen = new Pen(Color.Black,3f);
        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        public Paint()
        {
            InitializeComponent();

            SetSize();
            toolButtons.Add(PencilButton);
            toolButtons.Add(EraserButton);
            toolButtons.Add(FillColorButton);
            toolButtons.Add(ColorDropperButton);
            toolButtons.Add(LineButton);
            toolButtons.Add(RectangleButton);
            toolButtons.Add(CircleButton);
            sizeButtons.Add(SmailSizeButton);
            sizeButtons.Add(NormalSizeButton);
            sizeButtons.Add(MediumSizeButton);
            sizeButtons.Add(HighSizeButton);
        }
        private void Paint_Load(object sender, EventArgs e)
        {
            SetSize();
            NormalSizeButton.BackColor = Color.FromArgb(219, 235, 252);
            NormalSizeButton.BorderSize = 1;
            NormalSizeButton.BorderColor = Color.LightBlue;
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
                Drag = false;
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
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.Image = null;
            ExitButton.Image = Properties.Resources.multiply_white_20;
        }
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.Image = null;
            ExitButton.Image = Properties.Resources.icons8_multiply_black_20;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (isDrawn)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes to United ?", "Paint", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    SaveButton.PerformClick();
                    this.Show();
                    return;
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            Application.Exit();
        }
        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)            
                this.WindowState = FormWindowState.Maximized;           
            else 
                this.WindowState = FormWindowState.Normal;           
        }
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Minimized;
            
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFilePaint.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFilePaint.ShowDialog() == DialogResult.OK)
            {
                if (PicBox.Image == null)
                {
                    PicBox.Image.Save(saveFilePaint.FileName);
                }
            }
        }      
        private void ClearButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(PicBox.BackColor);
            PicBox.Image = map;
            isDrawn = false;
        }
        private void HomeButton_Click(object sender, EventArgs e)
        {
            ViewButton.BackColor = NavPanel.BackColor;
            HomeButton.BackColor = Color.FromArgb(245, 246, 247);

            viewForm.Hide();
            tableLayoutPanel1.Show();
        }
        private void ViewButton_Click(object sender, EventArgs e)
        {
            ViewButton.BackColor = Color.FromArgb(245, 246, 247);
            HomeButton.BackColor = NavPanel.BackColor;

            mainPanel.Controls.Add(viewForm);
            viewForm.BringToFront();
            viewForm.Show();
        }
        private void PicBox_Paint(object sender, PaintEventArgs e)
        {
            if(isMouse)
            {
                if (index == 6)
                {
                    e.Graphics.DrawRectangle(pen, rectangle);
                }
                else if (index == 7)
                {
                    e.Graphics.DrawEllipse(pen, rectangle);
                }
                else if (index == 5)
                {
                    e.Graphics.DrawLines(pen, points.ToArray());
                }
            }
        }
        private void PicBox_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
            isDrawn = true;
            if (index == 6)
            {
                rectangle = new Rectangle(e.Location, Size.Empty);
                points.Clear();
                points.Add(e.Location);
            }
            else if (index == 7)
            {
                startPoint = e.Location;
                points.Clear();
                points.Add(e.Location);
            }
            else if (index == 5)
            {
                startPoint = e.Location;
                endPoint = e.Location;
                points.Clear();
                points.Add(startPoint);
            }
            else if(index == 4)
            {
                Color pixelColor = map.GetPixel(e.X, e.Y);
                PenColor.BackColor = pixelColor;
                PencilButton.PerformClick();              
            }
        }
        private void PicBox_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;

            if (index == 6)
            {
                graphics.DrawRectangle(pen, rectangle);
                PicBox.Image = map;
                x = e.X;
                y = e.Y;
                arrayPoints.SetPoint(x, y);
            }
            else if (index == 7)
            {
                int radius = Math.Min(Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                int diameter = radius * 2;
                x = startPoint.X - radius;
                y = startPoint.Y - radius;
                graphics.DrawEllipse(pen, x, y, diameter, diameter);
                PicBox.Image = map;
            }
            else
            {
                if (index == 5)
                {
                    endPoint = e.Location;
                    graphics.DrawLine(pen, startPoint, endPoint);
                    PicBox.Image = map;
                }
            }
            arrayPoints.ResetPoint();
        }
        private void PicBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse)
            {
                return;
            }

            if (index == 6)
            {
                pen.Color = PenColor.BackColor;
                pen.Width = penSize;
                rectangle.Width = e.Location.X - rectangle.X;
                rectangle.Height = e.Location.Y - rectangle.Y;
            }
            else if (index == 7)
            {
                pen.Color = PenColor.BackColor;
                pen.Width = penSize;
                int radius = Math.Min(Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                int diameter = radius * 2;
                int x = startPoint.X - radius;
                int y = startPoint.Y - radius;
                rectangle = new Rectangle(x, y, diameter, diameter);
            }
            else if (index == 5)
            {
                pen.Color = PenColor.BackColor;
                pen.Width = penSize;
                endPoint = e.Location;
                points.Clear();
                points.Add(startPoint);
                points.Add(endPoint);
            }
            else
            {
                if (!isDrawingLine || index == 1 || index == 2 || index == 4)
                {
                    arrayPoints.SetPoint(e.X, e.Y);
                    if (arrayPoints.GetCountPoints() >= 2)
                    {
                        if (index == 2)
                        {
                            pen.Color = PicBox.BackColor;
                            pen.Width = penSize;
                            graphics.DrawLines(pen, arrayPoints.GetPoints());
                            PicBox.Image = map;
                            arrayPoints.SetPoint(e.X, e.Y);
                        }
                        else if(index == 4)
                        {
                            pen.Color = PenColor.BackColor;
                            pen.Width = penSize;
                            graphics.DrawLines(pen, arrayPoints.GetPoints());
                            PicBox.Image = map;
                            arrayPoints.SetPoint(e.X, e.Y);
                        }
                        else
                        {
                            pen.Color = PenColor.BackColor;
                            pen.Width = penSize;
                            graphics.DrawLines(pen, arrayPoints.GetPoints());
                            PicBox.Image = map;
                            arrayPoints.SetPoint(e.X, e.Y);
                        }
                        isDrawn = true;
                    }
                }
            }
            x = e.X;
            y = e.Y;
            PicBox.Invalidate();
        }
        private void PenColor_Click(object sender, EventArgs e)
        {
            pen.Color = ((MyPersonalPictureBox)sender).BackColor;
        }
        private void BtnColorOption_Click(object sender, EventArgs e)
        {
            pen.Color = ((MyPersonalPictureBox)sender).BackColor;
            PenColor.BackColor = ((MyPersonalPictureBox)sender).BackColor;
        }
        private void ColorSetButton_Click(object sender, EventArgs e)
        {
            if(picBoxColorDialog.ShowDialog() == DialogResult.OK)
            {
                pen.Color = picBoxColorDialog.Color;
                PenColor.BackColor = picBoxColorDialog.Color;
            }
        }         
        private void Button_Click(object sender, EventArgs e)
        {
            MyPersonalButton clickedButton = (MyPersonalButton)sender;

            clickedButton.BackColor = Color.LightBlue;
            clickedButton.BorderSize = 2;

            foreach (MyPersonalButton button in toolButtons)
            {
                if (button != (MyPersonalButton)sender)
                {
                    button.BackColor = Color.FromArgb(245, 246, 247);
                    button.BorderSize = 0;
                }
            }
        }       
        private void PencilButton_Click(object sender, EventArgs e)
        {
            index = 1;
            Button_Click(sender, e);
        }
        private void EraserButton_Click(object sender, EventArgs e)
        {
            index = 2;
            Button_Click(sender, e);
        }      
        private void FillColorButton_Click(object sender, EventArgs e)
        {
            index = 3;
            Button_Click(sender, e);
        }
        private void ColorDropperButton_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            index = 4;
        }
        private void LineButton_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            index = 5;
        }
        private void RectangleButton_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            index = 6;
        }
        private void CircleButton_Click(object sender, EventArgs e)
        {
            Button_Click(sender, e);
            index = 7;
        }
        private void FileButton_Click(object sender, EventArgs e)
        {
            
        }
        private void sizeButton_Click(object sender, EventArgs e)
        {
            RJButton clickedButton = (RJButton)sender;

            clickedButton.BackColor = Color.FromArgb(219, 235, 252);
            clickedButton.BorderSize = 1;
            clickedButton.BorderColor = Color.LightBlue;
            foreach (RJButton button in sizeButtons)
            {
                if (button != (RJButton)sender)
                {
                    button.BackColor = Color.FromArgb(245, 246, 247);
                    button.BorderSize = 0;
                }
            }
        }
        private void SmailSizeButton_Click(object sender, EventArgs e)
        {
            sizeButton_Click(sender, e);
            penSize = 1;
        }
        private void NormalSizeButton_Click(object sender, EventArgs e)
        {
            sizeButton_Click(sender, e);
            penSize = 3;
        }
        private void MediumSizeButton_Click(object sender, EventArgs e)
        {
            sizeButton_Click(sender, e);
            penSize = 5;
        }
        private void HighSizeButton_Click(object sender, EventArgs e)
        {
            sizeButton_Click(sender, e);
            penSize = 9;
        }
        private void SizeButton_MouseMove(object sender, MouseEventArgs e)
        {
            RJButton clickedButton = (RJButton)sender;
            clickedButton.Cursor = Cursors.Hand;
        }
    }
}
