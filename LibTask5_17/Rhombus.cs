using System.Collections.Generic;

namespace LibTask5_17
{
    public class Rhombus : GeometricFigure
    {
        double d1;
        double d2;

        public Rhombus(List<Point> points, bool isVisible, bool isCanChange) : base(points, isVisible, isCanChange)
        {
            d1 = points[0].DistanceTo(points[2]);
            d2 = points[1].DistanceTo(points[3]);
        }

        public override double CalkS()
        {
            return (d1 + d2) / 2;
        }
        
    }
}