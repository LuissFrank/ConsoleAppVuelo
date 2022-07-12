using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class InfoVuelo
    {

        public static string Informacion(string nombre, int hora)
        {

            var cod = (nombre.Substring(0, 3) + hora.ToString().Substring(0, 3)).ToUpper();

            Console.WriteLine("El codigo del vuelo a: " + nombre + " es: " + cod);

            return cod;

        }

        
    }
}
