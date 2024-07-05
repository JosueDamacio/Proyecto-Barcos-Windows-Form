using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public static class GenerarRandom
    {
        //public static double DoubleAleatorio(double x, double y)
        //{
        //    Random r = new Random();

        //    int resultado = r.Next(x, y);
        //    return resultado;
        //}
        public static int EnteroAleatorio(int x, int i)
        {
            Random r = new Random();

            int resultado = r.Next(x, y);
            return resultado;
        }

    }
}
