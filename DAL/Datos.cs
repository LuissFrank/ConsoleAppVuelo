using System;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Datos
    {
        private SqlConnection conex;

        public Datos(){
            conex = new SqlConnection();
            conex.ConnectionString="Server=localhost;database=VueloApp;trusted_connection=true";
            
        }
        public int EjecutarConsultaSinResultados(string consulta,SqlParameter[] parametros ){
            int cantidadFilasAfectadas=0;
            using(var comando=new SqlCommand(consulta,conex)){
                if(parametros!=null && parametros.Length>0)
                    comando.Parameters.AddRange(parametros);
                conex.Open();
                    cantidadFilasAfectadas=comando.ExecuteNonQuery();
                conex.Close();
            }
            return cantidadFilasAfectadas;
        }

        public DataTable MostrarDatos(string consulta,SqlParameter[] parametros){
            var dt=new DataTable();
            using(var comando=new SqlCommand(consulta,conex)){
                 if(parametros!=null && parametros.Length>0)
                    comando.Parameters.AddRange(parametros);
                var da=new SqlDataAdapter();
                da.SelectCommand=comando;
                conex.Open();
                da.Fill(dt);
                conex.Close();
            }
            return dt;
        }


        
    }
}
