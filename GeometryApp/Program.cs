using System;
using System.Collections.Generic;
using Figures;
using Calc;

namespace GeometryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== ЛР 24. Вариант 25 — min/max площадь треугольников ===\n");

            List<Triangle> triangles = TriangleList.DefaultSet();

            Console.Write("Добавить свои треугольники? (y/n): ");
            if (Console.ReadLine().Trim().ToLower() == "y")
            {
                Console.Write("Сколько добавить: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Console.Write("a b c: ");
                    string[] p = Console.ReadLine().Split();
                    triangles.Add(new Triangle(
                        double.Parse(p[0].Replace(',', '.')),
                        double.Parse(p[1].Replace(',', '.')),
                        double.Parse(p[2].Replace(',', '.'))));
                }
            }

            Console.WriteLine("\nСписок треугольников:");
            foreach (var t in triangles)
            {
                string status = t.IsValid() ? "" : " [невалидный]";
                double s = t.IsValid() ? AreaHelper.Area(t) : 0;
                Console.WriteLine("  {0}  S = {1:F3}{2}", t, s, status);
            }

            double minS, maxS;
            Triangle minT = AreaHelper.FindMinArea(triangles, out minS);
            Triangle maxT = AreaHelper.FindMaxArea(triangles, out maxS);

            Console.WriteLine("\n--- Результат ---");
            if (minT != null)
                Console.WriteLine("Наименьшая площадь: {0:F3}  у {1}", minS, minT);
            if (maxT != null)
                Console.WriteLine("Наибольшая площадь:  {0:F3}  у {1}", maxS, maxT);

            Console.WriteLine("\nНажмите Enter...");
            Console.ReadLine();

        }
    }
}
