
using System.Text;

namespace Clases
{
    public abstract class Barco
    {
        float costo;
        bool estadoReparado;
        string nombre;
        EOPeracion operacion;
        int tripulacion;

        public float Costo { get => costo; set => costo = value; }
        public bool EstadoReparado { get => estadoReparado; set => estadoReparado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public EOPeracion OPeracion { get => oPeracion; set => oPeracion = value; }
        public abstract int Tripulacion { get => tripulacion; set => tripulacion = value; }


        #region metodos

        public Barco()
        {
            //+ sobrecarga   
        }

        public abstract void CalcularCosto();

        public bool CompararBarcos()
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Costo: {costo}");
            sb.AppendLine($"Estado: {estadoReparado}");
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Operación: {OPeracion}");
            sb.AppendLine($"Tripulación : {tripulacion}");

            return sb.ToString();
        }

        #endregion

        #region Sobrecarga Operadores

        public static bool operator ==(Barco b1, Barco b2)
        {
            bool esIgual = false;
            if (b1.nombre == b2.nombre)
            {
                esIgual= true;
            }
            return esIgual;
        }
        public static bool operator !=(Barco b1, Barco b2)
        {return !(b1 == b2);}


            #endregion


        }
}
