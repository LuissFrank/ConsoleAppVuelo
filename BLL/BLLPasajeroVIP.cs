using System;
using Biblioteca;
using DAL;
using System.Collections.Generic;

namespace Biblioteca
{
    public class BLLPasajeroVIP
    {
        public PasajeroVIP BuscarId(int id)
        {
            var dalpac = new DALPasajeroVIP();
            return dalpac.MostrarPasajero(id);
        }

        public void Crear(PasajeroVIP pasVip)
        {
            var dalpac = new DALPasajeroVIP();
            dalpac.Agregar(pasVip);
        }


    }
}
