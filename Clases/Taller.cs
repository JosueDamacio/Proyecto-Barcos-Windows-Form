using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Taller
    {
        AccesoDatos data;
        List<Barco> listBarcos;
        public List<Barco> ListBarcos { get => listBarcos; set => listBarcos = value; }

        public Taller()
        {
            listBarcos = new List<Barco>();
            data = new AccesoDatos("localhost", "taller");
        }

        public bool EncontrarBarco(Barco b)
        {
            foreach (Barco barco in listBarcos)
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
                listBarcos.Add(b);
            }
            return this;
        }
        public bool Reparar(object x)
        {
            if (x is Taller tallerRecibido)
            {
                foreach(Barco bar in tallerRecibido.listBarcos)
                {
                    if (bar.EstadoReparado == false)
                    {
                        bar.CalcularCosto();
                        bar.EstadoReparado = true;

                        data.Modificar(bar);

                        return true;
                    }
                    return false;
                }
            }
            return false;
        }

        


    }
}
