using System.Collections.Generic;

namespace LibTask5_17
{
    public abstract class GeometricFigure : IFigure
    {
        
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
        public virtual void AddPoint(int x, int y)
        {
            if (Count > points.Count)
            {
                AddPoint(new Point(x, y));
            }
        }
        public void ChangePoint(int index, int x, int y)
        {
            ChangePoint(index, new Point(x, y));
        }

        public List<Point> points { get; set; }

        public double CalkP()
        {
            if (Count != points.Count) return 0;
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
        public override string ToString()
        {

            string s = "";
            for (int i = 0; i < points.Count; i++)
            {
                s += i + "точка " + points[i].ToString() + "\n";
            }
            s += "Видимость: " + isVisible + "\n";
            s += "Можно изменить: " + isCanChange + "\n";
            s += "Видимость: " + CalkP() + "\n";
            s += "Видимость: " + CalkS() + "\n";
            return s;

        }

        public int Count { get; set; }
    }
}
