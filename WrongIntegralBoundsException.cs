using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalIntegration
{
    class WrongIntegralBoundsException : Exception
    {
        public WrongIntegralBoundsException()
        {

        }

        public WrongIntegralBoundsException(string Message) : base(Message)
        {

        }
    }
}
