using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// Класс фигуры типа прямоугольник
    /// </summary>
    public class Rectangle : Figure
    {
        public Rectangle()
        {
        }


        /// <summary>
        /// Сторона А
        /// </summary>
        public double SideA { get; set; }

        /// <summary>
        /// Сторона B
        /// </summary>
        public double SideB { get; set; }


        #region Methods
        public override void Draw()
        {
            var length = SideA >= SideB ? SideA : SideB;
            var width = SideA >= SideB ? SideB : SideA;
            Console.WriteLine("Фигура Прумоугольник. Тип {0}: длина {1}  ширина {2}", this.GetType().FullName,length, width);
        }

        public override void CreateRandomFigure(int maxRand)
        {
            Random rand = new Random();
            SideA = rand.Next(maxRand);
            SideB = rand.Next(maxRand);
        }
        #endregion
    }
}
