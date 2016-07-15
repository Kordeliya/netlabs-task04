using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Figure figure = null;
                    Console.WriteLine("Выберите фигуру для создания: 1 - линия, 2 - круг, 3 - прямоугольник, 4 - треугольник, 5 - кольцо,");
                    string type = Console.ReadLine();
                    Console.WriteLine();
                    switch (type)
                    {
                        case "1":
                            figure = new Line();
                            break;
                        case "2":
                            figure = new Round();
                            break;
                        case "3":
                            figure = new Rectangle();
                            break;
                        case "4":
                            figure = new Triangle();
                            break;
                        case "5":
                            figure = new Ring();
                            break;
                        default:
                            Console.WriteLine("Введено неверное значение типа фигуры!");
                            break;

                    }
                    if (figure != null)
                    {
                        figure.CreateRandomFigure(100);
                        figure.Draw();
                    }
                    Console.WriteLine();
                }
                catch (FigureExeption ex)
                {
                    Console.WriteLine("Произошла ошибка! {0}", ex.Message);
                }
            }

        }
    }
}
