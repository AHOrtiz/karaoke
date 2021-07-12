using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace karaoke.Servicio
{
    public class ConexionMaestra
    {
        public static string conexion =("Data source= 192.168.1.67;Initial Catalog=KARAOKECURSO;Integrated Security=False;User Id=Allison123;Password=allison");
        public static SqlConnection conectar = new SqlConnection(conexion);

        public static void abrir()
        {
            if (conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
            }
        }
        public static void cerrar()
        {
            if (conectar.State == ConnectionState.Open)
            {
                conectar.Close();
            }
        }

    }
}
