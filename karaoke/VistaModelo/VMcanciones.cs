using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using karaoke.Servicio;
using System.Collections.ObjectModel;
using karaoke.Modelo;

namespace karaoke.VistaModelo
{
   public class VMcanciones
    {
        public void buscarCanciones(ref DataTable dt, string buscador)
        {
            try
            {
                ConexionMaestra.abrir();
                SqlDataAdapter da = new SqlDataAdapter("buscarCanciones", ConexionMaestra.conectar);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@letra", buscador);
                da.Fill(dt);
            }
            catch (Exception  ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            finally
            {
                ConexionMaestra.cerrar();
            }
        }
        public ObservableCollection<Mcanciones> ListarBuscarCanciones(string buscador)
        {
            ObservableCollection<Mcanciones> Canciones = new ObservableCollection<Mcanciones>();
            try
            {
                DataTable dt = new DataTable();
                buscarCanciones(ref dt,buscador);
                foreach  (DataRow rdr  in dt.Rows)
                {
                    Mcanciones parametros = new Mcanciones();
                    parametros.idCancion = Convert.ToInt32( rdr["idCancion"].ToString());
                    parametros.Nombre = rdr["Nombre"].ToString();
                    Canciones.Add(parametros);
                }
                return Canciones;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            return null;
        }
    }
}
