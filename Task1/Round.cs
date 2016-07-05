using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Класс окружности
    /// </summary>
    public class Round
    {
        #region Констуруторы

        public Round(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Round(double x, double y, double r)
            : this (x, y)
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
            private set {}

        }

        /// <summary>
        /// Длина окружности
        /// </summary>
        public double LengthRound
        {
            get
            {
                return 2* Math.PI * R;
            }
            private set{}
        }

    }
}
