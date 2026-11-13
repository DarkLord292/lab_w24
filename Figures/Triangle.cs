using System;

namespace Figures
{
    public class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a; B = b; C = c;
        }

        public bool IsValid()
        {
            return A + B > C && A + C > B && B + C > A
                    && A > 0 && B > 0 && C > 0;
        }

        public override string ToString()
        {
            return string.Format("Треугольник ({0}, {1}, {2})", A, B, C);
        }
    }
}
