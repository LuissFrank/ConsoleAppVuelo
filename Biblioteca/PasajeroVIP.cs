using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PasajeroVIP : Pasajero
    {
        

        public override int Descuento()
        {
            return 2000;
        }

        public override string Identificarse()
        {
            var info = "El pasajero: " + Nombre + " " + Apellido + " se registro con descuento: $" + Descuento() + " Tiene acceso a la sala VIP";
            Console.WriteLine(info);
            return info;
        }
    }
}
