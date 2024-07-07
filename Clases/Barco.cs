
using System.Text;
using static Clases.Barco;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clases
{
    public abstract class Barco
    {

        float costo;
        bool estadoReparado;
        string nombre;
        EOperacion operacion;
        int tripulacion;
        ETipoBarco tipo;
        int id;

        public float Costo { get => costo; set => costo = value; }
        public bool EstadoReparado { get => estadoReparado; set => estadoReparado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public EOperacion OPeracion { get => operacion; set => operacion = value; }
        public abstract int Tripulacion { get; set; }
        public ETipoBarco Tipo { get => tipo; set => tipo = value; }
        public int Id { get => id; set => id = value; }




        public Barco()
        {

        }
        protected Barco(string nombre, ETipoBarco tipo, EOperacion operacion)
        {
            this.nombre = nombre;
            this.Tipo = tipo;
            this.operacion = operacion;
            this.tripulacion = tripulacion;
        }

        public abstract void CalcularCosto();

        public bool CompararBarcos(Barco b2, Barco b1)
        {
            if (b1.nombre == b2.nombre)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre} ---");
            sb.AppendLine($"Estado reparacion: {estadoReparado}---");
            sb.AppendLine($"Operación: {OPeracion}");
            //sb.AppendLine($"Costo: {costo}");
            //sb.AppendLine($"Tripulación : {tripulacion}");

            return sb.ToString();
        }

        public static bool operator ==(Barco b1, Barco b2)
        {
            bool esIgual = false;
            if (b1.nombre == b2.nombre)
            {
                esIgual = true;
            }
            return esIgual;
        }
        public static bool operator !=(Barco b1, Barco b2)
        { return !(b1 == b2); }

    }

}
