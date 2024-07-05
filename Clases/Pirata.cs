using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{

    internal class Pirata : Barco
    {
        public override int Tripulacion
        {

  
            get => Tripulacion; //condicion
            set =>GenerarRandom.EnteroAleatorio(); 
        
        }

        public Pirata() : base()
        {
            //+ sobrecarga
        }

        public override void CalcularCosto()
        {
            throw new NotImplementedException();
        }

        public void CalcularCostos()
        {

        }
        
        public override string ToString()
        {

        }

    }
}
