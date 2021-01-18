using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTask5_17
{
    public interface IFigure
    {
        List<Point> points {
            get;
            set;
        }

        double CalkP();
        double CalkS();
    }
}
