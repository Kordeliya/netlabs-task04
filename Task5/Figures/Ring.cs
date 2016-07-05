using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    /// <summary>
    /// Класс фигуры типа Кольцо
    /// </summary>
    public class Ring : Figure
    {
        /// <summary>
        /// Внутреняя окружность
        /// </summary>
        public Round InsideOfRing { get; set; }

        /// <summary>
        /// Внешняя окружность
        /// </summary>
        public Round OuterOfRing { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Фигура Кольцо. Тип {0}: координаты центра ({1};{2}), радиусы граней {3} и {4}",
                    this.GetType().FullName, InsideOfRing.X, InsideOfRing.Y, InsideOfRing.R, OuterOfRing.R );
        }

        public override void CreateRandomFigure(int maxRand)
        {
            Random rand = new Random();
            OuterOfRing = new Round();
            OuterOfRing.CreateRandomFigure(maxRand);
            InsideOfRing = new Round();
            InsideOfRing.X = OuterOfRing.X;
            InsideOfRing.Y = OuterOfRing.Y;
            InsideOfRing.R = rand.Next((int)OuterOfRing.R);
        }
    }
}
