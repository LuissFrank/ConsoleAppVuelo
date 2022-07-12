using Biblioteca;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DAL
{
    public class DALPasajeroVIP
    {
        Datos datos;

        public DALPasajeroVIP()
        {
            datos = new Datos();
        }

        public PasajeroVIP MostrarPasajero(int id)
        {
            var pac = new PasajeroVIP();
            var cnx = new SqlConnection();
            cnx.ConnectionString="server=localhost;database=VueloApp;trusted_connection=true";
            cnx.Open();
                var comando = new SqlCommand("select *from pasajerovip where id=@cod",cnx);
                var paramId= new SqlParameter("@cod",id);
                comando.Parameters.Add(paramId);
                SqlDataReader dr = comando.ExecuteReader();
                while(dr.Read())
                {
                    pac.ID=dr.GetInt32(0);
                    pac.Nombre=dr.GetString(1);
                    pac.Apellido=dr.GetString(2);
                    pac.DNI=dr.GetInt32(3);
                    pac.CodigoBotelo=dr.GetString(4);
                }
            cnx.Close();
            return pac;
        }


        public void Agregar(PasajeroVIP pasVip)
        {
            var consulta = "insert into PasajeroVIP(Id,Nombre,Apellido,DNI,Boleto) values(@Id,@Nombre,@Apellido,@DNI,@Boleto)";
            datos.EjecutarConsultaSinResultados(consulta,MostrarParametros(true,pasVip));
        }

        private SqlParameter[] MostrarParametros(bool InsUpd, PasajeroVIP pasVip)
        {
            var paramId = new SqlParameter("@Id",pasVip.ID);
            var paramNombre = new SqlParameter("@Nombre", pasVip.Nombre);
            var paramApe = new SqlParameter("@Apellido", pasVip.Apellido);
            var paramDni = new SqlParameter("@DNI", pasVip.DNI);
            var paramboleto = new SqlParameter("@Boleto", pasVip.CodigoBotelo);
            if(InsUpd)
                return new SqlParameter[]{paramId,paramNombre,paramApe,paramDni,paramboleto};
            return new SqlParameter[]{paramId};
        }

    }
}