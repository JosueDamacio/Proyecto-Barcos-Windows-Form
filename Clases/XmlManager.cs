using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clases
{
    internal class XmlManager : IArchivos
    {
        string path = "..\\..\\..\\TallerXml.xml";


        public bool Guardar(List<Barco> listaBarcos)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(List<Barco>));
                    ser.Serialize(sw, listaBarcos);

                }
                return true;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Barco> leer()
        {
            {
                List<Barco> listaBarcos = new List<Barco>();

                if (!File.Exists(path))
                {
                    Guardar(listaBarcos);
                }
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        XmlSerializer des = new XmlSerializer(typeof(List<Barco>));
                        listaBarcos = (List<Barco>)des.Deserialize(sr);
                    }
                    Console.WriteLine("se leyo el archivo");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                return listaBarcos;
            }
        }
    }
}
