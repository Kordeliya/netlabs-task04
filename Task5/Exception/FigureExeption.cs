using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    [Serializable]
    public class FigureExeption : Exception
    {
        public FigureExeption()
        {
        }

        public FigureExeption(string message)
            : base(message)
        {
        }

        public FigureExeption(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public FigureExeption(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
