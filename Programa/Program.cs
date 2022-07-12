using System;
using Biblioteca;
using DAL;



namespace Programa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var vuelo1 = new Vuelo(InfoVuelo.Informacion("cordoba",1940));
            

            var pasajero8 = new BLLPasajeroFrecuente();
            pasajero8.Crear(new PasajeroFrecuente(){ID=5,Nombre="Sofia",Apellido="Hernandez",DNI=24458556,CodigoBotelo="wds3456"});
            Console.ReadKey();

            var pasajero1 = new BLLPasajeroFrecuente();
            var pasajero2 = new BLLPasajeroFrecuente();
            var pasajero3 = new BLLPasajeroFrecuente();
            var pasajero4 = new BLLPasajeroVIP();
            var pasajero5 = new BLLPasajeroVIP();

            

            //ingreso al vuelo
            vuelo1.Ingresar(pasajero1.BuscarId(1));
            vuelo1.Ingresar(pasajero2.BuscarId(2));
            vuelo1.Ingresar(pasajero3.BuscarId(3));
            vuelo1.Ingresar(pasajero4.BuscarId(1));
            vuelo1.Ingresar(pasajero5.BuscarId(2));
            //vuelo1.Ingresar(pasajero5);
            //vuelo1.Ingresar(pasajero6);
            //vuelo1.Ingresar(pasajero7);
            vuelo1.Ingresar(pasajero8.BuscarId(5));
            //vuelo1.Ingresar(piloto1);
            

            vuelo1.AsientosDisponibles();


            //lista de pasajeros
            vuelo1.ListaVuelo();
            //Console.ReadKey();

           
            vuelo1.TotalFinal();



            //instanciamos una sala vip solo para pasajeros vip
            var sala1 = new Sala();

            //error por no ser pasajero vip
            sala1.IngresoVip(pasajero4.BuscarId(1));
            //sala1.IngresoVip(pasajero2.BuscarId(2));
            //sala1.IngresoVip(pasajero6);
            
            

            
            

            //lista vip
            sala1.VipList();
        }
    }
}
