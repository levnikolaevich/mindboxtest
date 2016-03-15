using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDLL
{
    public class TriangleLN
    {

        /// <summary>
        /// Triangle Square
        /// </summary>
        /// <param name="a">1st side</param>
        /// <param name="b">2d side</param>
        /// <param name="c">3d side</param>
        public static double TriangleSQ(double a, double b, double c)
        {
            double s = 0;

            if (a > b && a > c)
            {

                if (Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2))
                    s = 0.5 * b * c;              

            }
            else if (b > a && b > c)
            {
                if (Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2))
                    s = 0.5 * a * c;
              
            }
            else
            {
                if (Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2))
                    s = 0.5 * a * b;                
            }               

            return s;
        }
    }
}
