using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Marina : Barco
    {
        private int tripulacion;
        public override int Tripulacion
        {
            get => tripulacion;
            
            set
            {
                if (value <= 0)
                {
                    tripulacion = GenerarRandom.EnteroAleatorio(30, 60);
                }
                else { tripulacion = value; }
            }
        }

        public Marina(string nombre, ETipoBarco tipo, EOperacion operacion)
            : base(nombre,tipo,operacion)
        {
            this.Tripulacion = tripulacion;
        }
        public Marina() : base()
        {
            
        }

        public override void CalcularCosto()
        {
            int costo = GenerarRandom.EnteroAleatorio(5000, 25000);
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
