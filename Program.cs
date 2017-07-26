using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mindbox
{
    public static class Program
    {
        static void Main(string[] args)
        {
        }
        static public double GetSquare(double a, double b, double c)
        {
            double aa = Math.Round(a * a, 5);
            double bb = Math.Round(b * b, 5);
            double cc = Math.Round(c * c, 5);

            if (cc == (aa + bb)) return a * b / 2;
            if (aa == (cc + bb)) return c * b / 2;
            if (bb == (aa + cc)) return a * c / 2;

            return -1;
        }
        static public double GetSquare(int a, int b, int c)
        {

            return GetSquare((double)a, (double)b, (double)c);
        }

        
        static public double GetSquare(float a, float b, float c)
        {
            return GetSquare((double) a, (double) b, (double) c);
        }


    }
}
