using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    [Serializable ]
    public class NotRightParametrsFiguresExceprion : FigureExeption
    {
        public NotRightParametrsFiguresExceprion()
        {
        }

        public NotRightParametrsFiguresExceprion(string message)
            : base(message)
        {
        }

        public NotRightParametrsFiguresExceprion(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        public NotRightParametrsFiguresExceprion(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
