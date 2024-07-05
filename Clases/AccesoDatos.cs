using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Clases
{
    public static class AccesoDatos
    {
        private static MySqlCommand command;
        private static MySqlConnection conection;

        static AccesoDatos()
        {
            
            conection = new MySqlConnection($"Server=localhost; DataBase=taller; User ID=root; Password=;SslMode=none;");

        }
        static bool Guardar(Barco b)
        {
            try
            {
                using (conection)
                {
                    conection.Open();
                    command = new MySqlCommand("INSERT INTO barcos(mensaje,alumno)" +
                        $"VALUES(@mensaje,@alumno)");

                    command.Parameters.AddWithValue("@mensaje", $"Se reparó el{b.Nombre} a un costo de {b.Costo} berries");
                    command.Parameters.AddWithValue("@alumno", "Josue");
                    return true;
                }
            }
            catch
            {
                return false;
            }

        }

    }
}
