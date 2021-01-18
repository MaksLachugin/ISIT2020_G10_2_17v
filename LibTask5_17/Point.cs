
using System;

namespace LibTask5_17
{
    public class Point
    {
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        private int x
        {
            get => x;
            set => x = value;
        }

        private int y
        {
            get => y;
            set => y = value;
        }
        public double DistanceTo(Point p)
        {
            return Math.Sqrt(Math.Pow(x - p.x, 2) + Math.Pow(y - p.y, 2));
        }

        public override string ToString()
        {
            return x + " " + y;
        }
    }
}