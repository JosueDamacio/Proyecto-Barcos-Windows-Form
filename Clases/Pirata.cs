using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{

    public class Pirata : Barco
    {
        private int tripulacion;
        public override int Tripulacion
        {
            get
            {
                return tripulacion;
            }
            set
            {
                if (value <= 0)
                {
                    tripulacion = GenerarRandom.EnteroAleatorio(10,30);
                }
                else { tripulacion = value; }
            }
        
        }

        public Pirata(string nombre, ETipoBarco tipo, EOperacion operacion)
            : base(nombre, tipo, operacion)
        {
            this.Tripulacion = tripulacion;
        }
        public Pirata() : base()
        {
            
        }

        public override void CalcularCosto()
        {
            int costo = GenerarRandom.EnteroAleatorio(2000,12000);
            this.Costo = costo;
        }
        
        public override string ToString()
        {
            StringBuilder sw = new StringBuilder();
            sw.Append(base.ToString());
            sw.AppendLine($"--- Cant.Tripulacion: {tripulacion}");

            return sw.ToString();
        }

    }
}
