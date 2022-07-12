using DAL;
using System.Collections.Generic;
using System.Linq;
using Biblioteca;
using System;




namespace Biblioteca
{
    public class BLLPasajeroFrecuente
    {
        //llamar a la dal
        
        public void Crear(PasajeroFrecuente pacfrec)
        {
            var dalpac = new DALPasajeroFrecuente();
            dalpac.Agregar(pacfrec);
        }

        public PasajeroFrecuente BuscarId(int id)
        {
            var dalpac = new DALPasajeroFrecuente();
            return dalpac.MostrarPasajero(id);
        }

       
    }
}