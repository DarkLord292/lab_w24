using System;
using System.Collections.Generic;
using Figures;

namespace Calc
{
    public static class AreaHelper
    {
        public static double Area(Triangle t)
        {
            double p = (t.A + t.B + t.C) / 2.0;
            return Math.Sqrt(p * (p - t.A) * (p - t.B) * (p - t.C));
        }

        public static Triangle FindMinArea(List<Triangle> list, out  double minArea)
        {
            minArea = double.MaxValue;
            Triangle minT = null;
            foreach (var t in list)
            {
                if (!t.IsValid()) continue;
                double s = Area(t);
                if (s < minArea)
                {
                    minArea = s;
                    minT = t;
                }
            }
            return minT;
        }

        public static Triangle FindMaxArea(List<Triangle> list, out double maxArea)
        {
            maxArea = double.MinValue;
            Triangle maxT = null;
            foreach(var t in list)
            {
                if (!t.IsValid()) continue;
                double s = Area(t);
                if (s < maxArea)
                {
                    maxArea = s; maxT = t;
                }
            }
            return maxT;
        }
    }
}