using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases.Excepciones
{
    public class DatoInvalidoException : Exception
    {
        string valor;

        public DatoInvalidoException(string msg, string valor) : base(msg)
        {
            this.valor = valor;
            LogException();
        }


        private void LogException()
        {
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Usuario\\Desktop\\SP_JosueDamacio\\logDatoInvalidoEx.txt",true))
            {
                sw.WriteLine($"{DateTime.Now}: Excepcion no controlada : {this.Message}. Valor {this.valor}");
            }
        }
    }
}
