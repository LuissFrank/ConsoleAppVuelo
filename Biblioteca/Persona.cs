using System;

namespace Biblioteca
{
    public abstract class Persona
    {
        
        public int ID {get;set;}
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }

        public virtual string Identificarse()
        {
            
            var info = "El pasajero: " + Nombre + Apellido + " se registro";
            Console.WriteLine(info);
            return info;
        }


    }
}
