using System;
using System.Data;
using System.Data.SqlClient;
using ReportesPadronNominal.Entidad;
using System.Windows.Forms;

namespace ReportesPadronNominal.Datos
{
    class dImportado: dConexion
    {
        public int InsertarImportado(Eimportado objImpor)
        {
            int res = 0;
            Conectar();
            string sql = "insert into importado(nombre,ruta,fecha) values('" + objImpor.nombre + "','" + objImpor.ruta + "',getDate())";
            SqlCommand cmd = new SqlCommand(sql, Conectar());
            res = cmd.ExecuteNonQuery();
            Desconectar();
            return res;
        }
        public int EditarImportado(Eimportado objImpor)
        {
            int res = 0;
            Conectar();
            string sql = "update importado set nombre='" + objImpor.nombre + "', descripcion='" + objImpor.ruta + "' where id_importado=" + objImpor.id + "";
            SqlCommand cmd = new SqlCommand(sql, Conectar());
            res = cmd.ExecuteNonQuery();
            Desconectar();
            return res;
        }
        
        public int EliminarImportado(Eimportado objImpor)
        {
            int res = 0;
            Conectar();
            string sql = "delete from importado where nombre='" + objImpor.nombre + "'";
            SqlCommand cmd = new SqlCommand(sql, Conectar());
            res = cmd.ExecuteNonQuery();
            Desconectar();
            return res;
        }
        public DataTable BuscarImportado(string nombre)
        {

            Conectar();
            string sql = "select * from importado where nombre = '" + nombre + "'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconectar();
            return dt;
        }
        public void ListarNominalesImportados(ref DataTable dt)
        {
            try
            {
                Conectar();
                SqlDataAdapter da = new SqlDataAdapter("SP_LISTAR_NOMINALES_IMPORTADOS", Conectar());
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                Desconectar();
            }
        }
        public void eliminarImortadoNominal(int anio, int mes)
        {
            //try
            //{
            Conectar();
            SqlCommand cmd = new SqlCommand("SP_ELIMINAR_NOMINAL_IMPORTADO", Conectar());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@anio", anio);
            cmd.Parameters.AddWithValue("@mes", mes);
            cmd.ExecuteNonQuery();
            Desconectar();

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //    return false;
            //}
            //finally
            //{
            //    Desconectar();
            //}
        }
    }
}
