using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTask4_17_5
{
    public class Utils<T>
    {
        public static List<T> Clone(List<T> list)
        {
            T[] t = new T[list.Count];
            list.CopyTo(t);
            return new List<T>(t);
        }
    }
}
