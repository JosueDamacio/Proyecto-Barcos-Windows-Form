
using System.Text;
using static Clases.Barco;

namespace Clases
{
    public abstract class Barco
    {
        public enum EOperacion
        {
            Rerarar_Mastil,
            Pintar,
            Cambiar_Velas,
            Reparar_Mascaron,
            Reparar_Casco,
            Recargar_Cañones
        }
        public enum ETipoBarco
        {
            Pirata,
            Marina
        }

        float costo;
        bool estadoReparado;
        string nombre;
        private EOperacion operacion;
        int tripulacion;

        public float Costo { get => costo; set => costo = value; }
        public bool EstadoReparado { get => estadoReparado; set => estadoReparado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public EOperacion OPeracion { get => operacion; set => operacion = value; }
        protected abstract int Tripulacion { get; set; }


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
