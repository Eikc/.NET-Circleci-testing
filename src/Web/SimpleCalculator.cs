using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web
{
    public class SimpleCalculator
    {
        public static double Add(double x, double y) => x + y;

        public static bool IsOdd(int value) => value % 2 == 1;
    }
}
