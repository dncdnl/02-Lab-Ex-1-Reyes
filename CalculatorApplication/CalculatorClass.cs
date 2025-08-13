using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    // Declaring a generic Formula
    public delegate X Formula<X>(X arg1);
    internal class CalculatorClass
    {
        public Formula<double> formula;
    }
}
