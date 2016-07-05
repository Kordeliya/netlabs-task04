using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// Класс фигуры типа треугольник
    /// </summary>
    public class Triangle : Figure
    {
        #region Конструкторы

        public Triangle()
        {
        }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }
        #endregion

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


        #region Methods

        /// <summary>
        /// Получение площади
        /// </summary>
        public double GetArea()
        {
            double p = GetSemiPerimeter();
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
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

        /// <summary>
        /// Проверка возможности треугольникас указанными сторонами
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool CanBeTriangle(double a, double b, double c)
        {
            return (a + b > c ? true : false) && (a + c > b ? true : false) && (b + c > a ? true : false);
        }


        /// <summary>
        /// Имитация рисования
        /// </summary>
        public override void Draw()
        {
            Console.WriteLine("Фигура Треугольникю Тип {0}: Стороны А {1} B {2} C {3} площадь: {4}",
                this.GetType().FullName, SideA, SideB, SideC, GetArea().ToString("#.000"));
        }

        /// <summary>
        /// Создание фигуры со случайными параметрами
        /// </summary>
        public override void CreateRandomFigure(int maxRand)
        {
            Random rand = new Random();
            do
            {
                SideA = rand.Next(maxRand);
                SideB = rand.Next(maxRand);
                SideC = rand.Next(maxRand);
            }
            while (!Triangle.CanBeTriangle(SideA, SideB, SideC));
        }


        #endregion
    }
}
