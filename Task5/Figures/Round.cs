using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// Класс фигуры типа Окружность
    /// </summary>
    public class Round : Figure
    {
        #region Констуруторы

        public Round()
        {
        }

        public Round(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Round(double x, double y, double r)
            : this(x, y)
        {
            R = r;
        }

        #endregion

        /// <summary>
        /// Координата X центра окружности
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Координата Y центра окружности
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Радиус
        /// </summary>
        public double R { get; set; }

        /// <summary>
        /// Площадь
        /// </summary>
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(R, 2);
            }

        }

        /// <summary>
        /// Длина окружности
        /// </summary>
        public double LengthRound
        {
            get
            {
                return 2 * Math.PI * R;
            }
        }

        #region Methods

        /// <summary>
        /// Имитация рисования
        /// </summary>
        public override void Draw()
        {
            Console.WriteLine("Фигура Круг. Тип {0}: координаты центра ({1};{2}), радиус {3}",
                    this.GetType().FullName, X, Y, R);
        }

        /// <summary>
        /// Создание фигуры со случайными параметрами
        /// </summary>
        public override void CreateRandomFigure(int maxRand)
        {
            Random rand = new Random();
            X = rand.Next(maxRand);
            Y = rand.Next(maxRand);
            R = rand.Next(maxRand);
        }
        #endregion


    }
}
