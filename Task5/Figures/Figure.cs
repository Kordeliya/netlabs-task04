using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public abstract class Figure : IFigure
    {
        public abstract void Draw();

        public abstract void CreateRandomFigure(int maxRand);
    }
}
