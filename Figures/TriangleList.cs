using System.Collections.Generic;

namespace Figures
{
    public static class TriangleList
    {
        public static List<Triangle> DefaultSet()
        {
            return new List<Triangle>()
            {
                new Triangle(3, 4, 5),
                new Triangle(5, 5, 6),
                new Triangle(2, 3, 4),
                new Triangle(6, 8, 10),
                new Triangle(7, 8, 9)
            };
        }
    }
}
