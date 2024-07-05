using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{

    internal class Pirata : Barco
    {
        protected override int Tripulacion
        {
            get
            {
                return Tripulacion;
            }
            set
            {
                if (value <= 0)
                {
                    Tripulacion = GenerarRandom.EnteroAleatorio(10,30);
                }
                Tripulacion = value;
            }
        
        }

        public Pirata() : base()
        {
            //+ sobrecarga
        }

        public override void CalcularCosto()
        {
            int costo = GenerarRandom.EnteroAleatorio(2000,12000);
            this.Costo = costo;
        }

        public void CalcularCostos()
        {

        }
        
        public override string ToString()
        {
            return base.ToString();
        }

    }
}
