using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Piloto : Persona
    {
        

        public override string Identificarse()
        {
            var info = "El piloto " + Apellido + " Ingreso al vuelo";
            Console.WriteLine(info);
            return info;
        }
    }
}
