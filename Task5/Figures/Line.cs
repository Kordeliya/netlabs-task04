using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// Класс фигуры типа Линия
    /// </summary>
    public class Line : Figure
    {
        #region Конструкторы

        public Line() { }

        public Line(double x_f, double y_f,double x_s, double y_s)
        {
            X_FirstPoint = x_f;
            Y_FirstPoint = y_f;
            X_SecondPoint = x_s;
            Y_SecondPoint = y_s;
        }
        #endregion

        /// <summary>
        /// Координата X первой точки
        /// </summary>
        public double X_FirstPoint { get; set; }

        /// <summary>
        /// Координата Y первой точки
        /// </summary>
        public double Y_FirstPoint { get; set; }

        /// <summary>
        /// Координата X первой точки
        /// </summary>
        public double X_SecondPoint { get; set; }


        /// <summary>
        /// Координата Y второй точки
        /// </summary>
        public double Y_SecondPoint { get; set; }

        #region Methods

        public override void Draw()
        {
            Console.WriteLine("Фигура Линияю Тип {0}: координата 1 точки ({1};{2}), координата 2 точки ({3};{4})",
                                this.GetType().FullName, X_FirstPoint, Y_FirstPoint, X_SecondPoint, Y_SecondPoint);

        }

        public override void CreateRandomFigure(int maxRand)
        {
            Random rand = new Random();
            X_FirstPoint = rand.Next(maxRand);
            Y_FirstPoint = rand.Next(maxRand);
            X_SecondPoint = rand.Next(maxRand);
            Y_SecondPoint = rand.Next(maxRand);

        }
        #endregion
    }
}
