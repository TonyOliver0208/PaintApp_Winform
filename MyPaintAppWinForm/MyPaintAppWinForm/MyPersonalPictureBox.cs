using MyPersonalCustomizeButton;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaintAppWinForm
{
    class MyPersonalPictureBox : PictureBox
    {
        private int borderSize = 2;
        private int borderRadius = 40;
        private float gradientAngle = 90F;
        private Color borderGradientTop = Color.DodgerBlue;
        private Color bordeGradientBottom = Color.CadetBlue;

        public MyPersonalPictureBox()
        {
            SizeMode = PictureBoxSizeMode.StretchImage;
            Size = new Size(120, 120);
        }

        public int BorderSize
        {
            get { return borderSize; }
            set { borderSize = value; Invalidate(); }
        }
        public int BorderRadius
        {
            get { return borderRadius; }
            set { borderRadius = value; Invalidate(); }
        }
        public float GradientAngle
        {
            get { return gradientAngle; }
            set { gradientAngle = value; Invalidate(); }
        }
        public Color BorderGradientBottom
        {
            get { return borderGradientTop; }
            set { borderGradientTop = value; Invalidate(); }
        }
        public Color BordeGradientBottom
        {
            get { return bordeGradientBottom; }
            set { bordeGradientBottom = value; Invalidate(); }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Size = new Size(Width, Width);
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            var graphics = pe.Graphics;
            var rectangleSmooth = Rectangle.Inflate(ClientRectangle, -1, -1);
            var rectangleBorder = Rectangle.Inflate(rectangleSmooth, -borderSize, -borderSize);
            var SmoothSize = borderSize > 0 ? borderSize * 3 : 1;

            using (var borderGradientColor = new LinearGradientBrush(rectangleBorder, borderGradientTop, bordeGradientBottom, gradientAngle))
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(Parent.BackColor, SmoothSize))
            using (var penBorder = new Pen(borderGradientColor, SmoothSize))
            {
                pathRegion.AddEllipse(rectangleSmooth);
                Region = new Region(pathRegion);
                graphics.SmoothingMode = SmoothingMode.AntiAlias;
                graphics.DrawEllipse(penSmooth, rectangleSmooth);

                if (borderSize > 0)
                    graphics.DrawEllipse(penBorder, rectangleBorder);
            }
            Size = new Size(Width, Width);
        }
    }
}
