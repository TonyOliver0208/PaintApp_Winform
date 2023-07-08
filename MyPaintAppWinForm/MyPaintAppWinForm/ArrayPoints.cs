using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaintAppWinForm
{
    internal class ArrayPoints
    {
        private int index = 0;
        private Point[] points;
        
        public ArrayPoints(int size)
        {
            if(size <= 2)
                size = 2;
            points = new Point[size];
        }

        public void SetPoint(int x,int y)
        {
            if(index >= points.Length)
                index = 0;
            points[index] = new Point(x,y);
            index++;
        }

        public void ResetPoint()
        {
            index = 0;
        }
        public int GetCountPoints()
        {
            return index;
        }
        public Point[] GetPoints()
        {
            return points;
        }

        public void Clear()
        {
            index = 0;
            Array.Clear(points, 0, points.Length);
        }
       

    }
}
