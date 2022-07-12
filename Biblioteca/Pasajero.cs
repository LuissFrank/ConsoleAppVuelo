using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Pasajero : Persona
    {
        
        
        public string CodigoBotelo { get; set; }

        public abstract int Descuento();
    }
}
