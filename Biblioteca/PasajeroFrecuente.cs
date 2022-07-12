using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PasajeroFrecuente : Pasajero
    {
        

        public override int Descuento()
        {
            return 1000;

        }


        public override string Identificarse()
        {
            var info = "El pasajero " + Nombre + " " + Apellido + " " + " Se registro con descuento: $" + Descuento();
            Console.WriteLine(info);
            return info;

        }

    }
}
