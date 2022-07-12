using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Sala
    {


        private List<Pasajero> SalaVip;
        public void IngresoVip(Pasajero pac)
        {
            try
            {
                if (SalaVip is null && pac.GetType() != typeof(PasajeroFrecuente))
                {

                    SalaVip = new List<Pasajero>();

                }
                SalaVip.Add(pac);

            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Usted no puede ingresar a esta sala");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
            }
            
        }

        public void VipList()
        {
            Console.WriteLine("INGRESO DE MIEMBROS VIP");
            Console.WriteLine("-----------------------");
            foreach (Pasajero pac in SalaVip)
            {
                Console.WriteLine("Miembro: " + pac.Apellido);
            }
        }


    }
}
