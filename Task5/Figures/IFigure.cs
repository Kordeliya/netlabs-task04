using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    interface IFigure
    {

        /// <summary>
        /// Имитация рисования
        /// </summary>
        void Draw();

        /// <summary>
        /// Имитация рисования
        /// </summary>
        /// <param name="maxRand"></param>
        void CreateRandomFigure(int maxRand);
    }
}
