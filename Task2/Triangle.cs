using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle
    {

        public Triangle(double a, double b, double c)
        {
            if (!CanBeTriangle(a, b, c))
                throw new Exception("Размеры сторон не соответствуют правилу");
            SideA = a;
            SideB = b;
            SideC = c;
        }

        /// <summary>
        /// Сторона А
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// Сторона B
        /// </summary>
        public double SideB { get; set; }

        /// <summary>
        /// Сторона C
        /// </summary>
        public double SideC { get; set; }

        /// <summary>
        /// Получение площади
        /// </summary>
        public double GetArea()
        {
            double p = GetSemiPerimeter();
            return Math.Sqrt(p*(p-SideA)*(p-SideB)*(p-SideC));
        }

        /// <summary>
        /// Получение периметра
        /// </summary>
        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        /// <summary>
        /// Получение полупериметра
        /// </summary>
        /// <returns></returns>
        private double GetSemiPerimeter()
        {
            double per = GetPerimeter();
            return per / 2;
        }


        public static bool CanBeTriangle(double a, double b, double c)
        {
            return (a+b>c ? true : false)  && (a+c>b ? true : false) && (b+c>a ? true : false);
        }

    }
}
