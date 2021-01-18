using System.Collections.Generic;

namespace LibTask5_17
{
    public abstract class GeometricFigure : IFigure
    {
        public GeometricFigure(List<Point> points, bool isVisible, bool isCanChange)
        {
            this.points = points;
            this.isVisible = isVisible;
            this.isCanChange = isCanChange;
        }


        public List<Point> points
        {
            get => points;
            set => points = value;
        }
        public void AddPoint(Point point)
        {
            if (isCanChange)
            {
                points.Add(point);
            }
        }
        public void RemovePoint(int i)
        {
            if (isCanChange)
            {
                points.RemoveAt(i);
            }
        }

        public bool isVisible;
        public bool isCanChange;

        public void ChangePoint(int index, Point point)
        {
            if (isCanChange)
            {
                points[index] = point;
            }
        }
        public void AddPoint(int x, int y)
        {
            AddPoint(new Point(x, y));
        }
        public void ChangePoint(int index, int x, int y)
        {
            ChangePoint(index, new Point(x, y));
        }

        public double CalkP()
        {
            double sum = 0;
            for (int i = 0; i < points.Count; i++)
            {
                if (i + 1 == points.Count)
                {
                    sum += points[i].DistanceTo(points[0]);
                }
                else { sum += points[i].DistanceTo(points[i + 1]); }
            }
            return sum;
        }

        public abstract double CalkS();
        public virtual string ToString
        {
            get
            {
                string s = "";
                for (int i = 0; i < points.Count; i++)
                {
                    s += i + "точка " + points[i].ToString() + "\n";
                }
                s += "Видимость: " + isVisible + "\n";
                s += "Можно изменить: " + isCanChange + "\n";
                s += "Видимость: " +CalkP() + "\n";
                s += "Видимость: " +CalkS() + "\n";
                return s;
            }
        }
    }
}
