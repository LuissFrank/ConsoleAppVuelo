using Biblioteca;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System;

namespace DAL
{
    public class DALPasajeroFrecuente
    {
        Datos datos;

        public DALPasajeroFrecuente()
        {
            datos = new Datos();
        }
        public PasajeroFrecuente MostrarPasajero(int id)
        {
            var pac = new PasajeroFrecuente();
            var cnx = new SqlConnection();
            cnx.ConnectionString="server=localhost;database=VueloApp;trusted_connection=true";
            cnx.Open();
                var comando = new SqlCommand("select *from pasajerofrecuente where id=@cod",cnx);
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
        

        public void Agregar(PasajeroFrecuente pasFrec)
        {
            var consulta = "insert into PasajeroFrecuente(Id,Nombre,Apellido,DNI,Boleto) values(@Id,@Nombre,@Apellido,@DNI,@Boleto)";
            datos.EjecutarConsultaSinResultados(consulta,MostrarParametros(true,pasFrec));
        }

        private SqlParameter[] MostrarParametros(bool InsUpd, PasajeroFrecuente pasFrec)
        {
            var paramId = new SqlParameter("@Id",pasFrec.ID);
            var paramNombre = new SqlParameter("@Nombre", pasFrec.Nombre);
            var paramApe = new SqlParameter("@Apellido", pasFrec.Apellido);
            var paramDni = new SqlParameter("@DNI", pasFrec.DNI);
            var paramboleto = new SqlParameter("@Boleto", pasFrec.CodigoBotelo);
            if(InsUpd)
                return new SqlParameter[]{paramId,paramNombre,paramApe,paramDni,paramboleto};
            return new SqlParameter[]{paramId};
        }


    }
}