using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterPol
{
    public class DiscountCalculator
    {
        public static double CalculateDiscount(double salesAmount)
        {
            if (salesAmount <= 10000)
                return 0;
            else if (salesAmount > 10000 && salesAmount <= 50000)
                return 5;
            else if (salesAmount > 50000 && salesAmount <= 300000)
                return 10;
            else
                return 15;
        }
    }
}
