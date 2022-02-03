using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericalIntegration
{
    interface IPolynomialCoefficients
    {
        double[] GetCoefficients(string Input);
    }
}
