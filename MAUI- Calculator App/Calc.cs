using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI__Calculator_App
{
    internal static class Calc
    {
        internal static double Do(double d1,double d2,string ch)
        {
      
            switch (ch)
            {
                case "/":
                    return d1 / d2;
                case "X":
                    return d1 * d2;
                case "+":
                    return d1 + d2;
                case "-":
                    return d1 - d2;
                default:
                    break;

            }

            return 0;
          
        }
    }
}
