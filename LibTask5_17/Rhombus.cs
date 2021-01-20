using System.Collections.Generic;

namespace LibTask5_17
{
    public class Rhombus : GeometricFigure
    {
        double d1 = 0;
        double d2 = 0;

        // public Rhombus(List<Point> points, bool isVisible, bool isCanChange) : base(points, isVisible, isCanChange)
        //        {
        //         d1 = points[0].DistanceTo(points[2]);
        //         d2 = points[1].DistanceTo(points[3]);
        //       }
        public Rhombus()
        {
            Count = 4;
            points = new List<Point>();

            isVisible = true;
            isCanChange = false;
        }

        public override void AddPoint(int x, int y)
        {
            points.Add(new Point(x, y));
            if (Count == points.Count)
            {
                d1 = points[0].DistanceTo(points[2]);
                d2 = points[1].DistanceTo(points[3]);
            }
        }
        public override double CalkS()
        {

            return (d1 + d2) / 2;
        }

    }
}