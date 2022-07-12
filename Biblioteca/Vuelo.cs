using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;


namespace Biblioteca
{
    public sealed class Vuelo
    {
        public Vuelo(string codigo)
        {
            Codigo = codigo;
        }
        public string Codigo { get; private set; }
        private int Precio { get { return 5000; } }
        private int Asientos { get { return 7; } }

        private List<Persona> pasajeros;

        public int Recaudacion() //Recaudacion total del vuelo
        {

            var rec = pasajeros.Count() * Precio;
            Console.WriteLine("Total de recaudacion:$ " + rec);
            return rec;

        }



        public void Ingresar(Persona pas) //ingreso de pasajeros
        {

            if (pasajeros is null)
            {
                pasajeros = new List<Persona>();

            }
            if (pasajeros.Count() < Asientos && pas.GetType() != typeof(Piloto))
            {
                pasajeros.Add(pas);
                pas.Identificarse();
            }
            else if (pas.GetType() == typeof(Piloto))
            {

                pas.Identificarse();
            }
            else
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Pasajero con nombre: " + pas.Nombre + " " + pas.Apellido + " No puede Identificarse");
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        public int AsientosDisponibles()
        {
            var disp = Asientos - pasajeros.Where(x => x.GetType() != typeof(Pasajero)).ToList().Count();
            if (disp == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No quedan asientos");
                Console.ForegroundColor = ConsoleColor.White;
                return disp;
            }
            Console.WriteLine("Asientos disponibles: " + disp);

            return disp;

        }


        public int TotalFinal() //Total final con los descuentos
        {
            int desc = 0;
            foreach (Pasajero pac in pasajeros)
            {
                desc += pac.Descuento();

            }
            var TotalFinal = Recaudacion() - desc;
            Console.WriteLine("Total Final:$ " + TotalFinal);

            return TotalFinal;
        }

        public void TotalPasajeros() //total de pasajeros
        {

            var total = pasajeros.Count;
            Console.WriteLine("---Pasajeros totales: " + total + "---");
        }

        public void ListaVuelo() //lista de pasajeros
        {
            Console.WriteLine(" ------------------");
            Console.WriteLine("| LISTA DE PASAJEROS |");
            Console.WriteLine(" ------------------");
            foreach (Pasajero pac in pasajeros)
            {
                Console.WriteLine("Nombre y Apellido: " + pac.Nombre + " " + pac.Apellido);
                Console.WriteLine("------------------------------------------------------");
            }

            PasajerosVip();
            PasajerosFrecuentes();
            TotalPasajeros();
        }

        public void PasajerosFrecuentes()
        {
            var busqueda = pasajeros.Where(x => x.GetType() == typeof(PasajeroFrecuente)).ToList().Count();
            Console.WriteLine("Numero de pasajeros Frecuentes: " + busqueda);

        }


        public void PasajerosVip()
        {
            var busqueda2 = pasajeros.Where(x => x.GetType() == typeof(PasajeroVIP)).ToList().Count();
            Console.WriteLine("Numero de pasajeros VIP: " + busqueda2);
        }

        


    }
}
