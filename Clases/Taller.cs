using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Taller
    {
        List<Barco> barcos;
        public List<Barco> Barcos { get => barcos; set => barcos = value; }

        public Taller()
        {
            barcos = new List<Barco>();

        }

        public bool EncontrarBarco(Barco b)
        {
            foreach (Barco barco in barcos)
            {
                if (b == barco)
                {
                    return true;
                }
            }
            return false;
        }

        public Taller IngresarBArco(Barco b)
        {
            if (!EncontrarBarco(b))
            {
                barcos.Add(b);
            }
            return this;
        }
        public bool Reparar(object x)
        {
            if (x is Taller)
            {
                foreach(Barco bar in barcos)
                {
                    if (bar.EstadoReparado == false)
                    {
                        bar.CalcularCosto();





                        bar.EstadoReparado = true;
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        


    }
}
