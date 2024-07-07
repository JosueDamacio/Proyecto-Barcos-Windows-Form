using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal interface IArchivos
    {
        public bool Guardar(List<Barco> listaBarcos);
        public List<Barco> leer();

    }
}
