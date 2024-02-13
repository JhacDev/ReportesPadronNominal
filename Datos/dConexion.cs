using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ReportesPadronNominal.Datos
{
    class dConexion
    {
        SqlConnection cn;
        public SqlConnection Conectar()
        {
            try
            {
                cn = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                cn.Open();
            }
            catch (Exception)
            {
                cn.Close();
                Console.WriteLine("Error de conexion");
            }
            return cn;
        }

        public void Desconectar()
        {
            if(cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
        }
        internal SqlConnection GetConexion()
        {
            throw new NotImplementedException();
        }
    }
}
