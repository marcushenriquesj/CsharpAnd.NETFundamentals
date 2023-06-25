using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingExample
{
    public class Calculator
    {

        public decimal Sum(decimal val1, decimal val2)
        {
            return val1 + val2;
        }

        public decimal Divide(decimal val1, decimal val2)
        {
            return val1 / val2;
        }
    }
}
