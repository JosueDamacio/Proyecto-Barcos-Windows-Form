using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Marina : Barco
    {
        public override int Tripulacion
        { get => Tripulacion;
            
          set
            {
                if (value <= 0)
                {
                    Tripulacion = GenerarRandom.EnteroAleatorio(30, 60);
                }
                Tripulacion = value;
            }
        }

        public Marina()
        {
            //+ sobrecarga
        }


        public override void CalcularCosto()
        {
            int costo = GenerarRandom.EnteroAleatorio(5000, 25000);
            this.Costo = costo;
        }

        public override string ToString()
        {
            return base.ToString();
        }



    }
}
