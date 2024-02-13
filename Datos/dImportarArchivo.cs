using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ReportesPadronNominal.Datos
{
    class dImportarArchivo:dConexion
    {
        //1. Importar Archivo
        public int ImportarArchivoCSV(string ruta, string tabla)
        {
            int resultado = 0;
            Conectar();
            try
            {
                string sql = "BULK INSERT " + tabla + " FROM '" + ruta + "' with(\r\n\tFIELDTERMINATOR =',',\r\n\tROWTERMINATOR='\\n',\r\n\tFIRSTROW=2\r\n)";

                SqlCommand cmd = new SqlCommand(sql, Conectar());

                cmd.CommandTimeout = 0;
                resultado = cmd.ExecuteNonQuery();
                Desconectar();
            }
            catch (Exception ex)
            {
                resultado = 0;
                Console.WriteLine("Error en Importar " + ex.Message);
                Desconectar();
            }
            return resultado;
        }
        public DataTable TotalRegistro(string nombreTabla)
        {
            Conectar();
            string sql = "SELECT COUNT(*) AS TOTAL_CANTIDAD FROM " + nombreTabla;

            SqlDataAdapter da = new SqlDataAdapter(sql, Conectar());
            DataTable dt = new DataTable();
            da.Fill(dt);
            Desconectar();
            return dt;
        }

        public void LimpiarTabla(string nombreTable)
        {
            Conectar();
            string sql = "TRUNCATE TABLE " + nombreTable;
            SqlCommand cmd = new SqlCommand(sql, Conectar());
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 0;
            cmd.ExecuteNonQuery();
            Desconectar();
        }
        /*Importacion de Padron Nominal y CNV*/
        //1. Importar Padron Nominal
        public int ImportarPadronNominal(string ruta, string tabla)
        {
            int resultado = 0;
            Conectar();
            try
            {
                SqlCommand cmd = new SqlCommand(@"BULK INSERT " + tabla + " FROM '" + ruta + "'", Conectar());

                cmd.CommandTimeout = 0;
                resultado = cmd.ExecuteNonQuery();
                Desconectar();
            }
            catch (Exception ex)
            {
                resultado = 0;
                Console.WriteLine("Error en Importar " + ex.Message);
                Desconectar();
            }
            return resultado;
        }

        /*--------------------ACTUALIZAR TIPO DOCUMENTO CNV Y DNI--------------------------------------------*/

        //3. Actualizar Tipo de Documento Todos los pacientes que tiene Nro. Doc. DNI
        public int ActualizarDNI_PadronNominal()
        {
            int resultado = 0;
            Conectar();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Padron_Nominal SET Tipo_Doc = 'DNI' WHERE isnumeric(DNI)>0", Conectar());
                cmd.CommandTimeout = 0;
                resultado = cmd.ExecuteNonQuery();
                Desconectar();
            }
            catch (Exception ex)
            {
                resultado = 0;
                Console.WriteLine("Error en Act. DNI " + ex.Message);
                Desconectar();
            }
            return resultado;
        }

        //4. Actualizar Tipo de Documento Todos los pacientes que tiene Nro. Doc. CNV
        public int ActualizarCNV_PadronNominal()
        {
            int resultado = 0;
            Conectar();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Padron_Nominal SET Tipo_Doc='CNV' WHERE DNI IS NULL AND ISNUMERIC(CNV)>0", Conectar());
                cmd.CommandTimeout = 0;
                resultado = cmd.ExecuteNonQuery();
                Desconectar();
            }
            catch (Exception ex)
            {
                resultado = 0;
                Console.WriteLine("Error en Act. CNV " + ex.Message);
                Desconectar();
            }
            return resultado;
        }

        //5. Agregar codigo CNV a DNI
        public int AgregarCNV_DNI_PadronNominal()
        {
            int resultado = 0;
            Conectar();
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Padron_Nominal SET DNI=CNV WHERE DNI IS NULL AND ISNUMERIC(CNV)>0", Conectar());
                cmd.CommandTimeout = 0;
                resultado = cmd.ExecuteNonQuery();
                Desconectar();
            }
            catch (Exception ex)
            {
                Desconectar();
                Console.WriteLine("Error en Agregar CNV DNI " + ex.Message);
                return resultado;
            }
            return resultado;
        }
        /*-----------------------QUERY ELIMINAR TIPODICUMENTO Y TIPO SEGURO-----------------------------------------*/

        //6. Eliminar Todos los personal con Tipo Documento CUI Y PN
        public int Eliminar_CUI_PN_PadronNominal()
        {
            int resultado = 0;
            Conectar();
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Padron_Nominal WHERE DNI IS NULL", Conectar());
                cmd.CommandTimeout = 0;
                resultado = cmd.ExecuteNonQuery();
                Desconectar();
            }
            catch (Exception ex)
            {

                resultado = 0;
                Console.WriteLine("Error en Eliminar CUI PN " + ex.Message);
                Desconectar();
            }
            return resultado;
        }

        //7. Eliminar todos los personas con tipo de seguro ESSALUD,PRIVADO
        public int EliminarTipoSeguro_ESSALUD_PRIVADO_PadronNominal()
        {
            int resultado = 0;
            Conectar();
            try
            {

                string sql = "DELETE FROM Padron_Nominal where Tipo_Seguro in ('\"4, \"','\"2, \"','\"2, 4, \"')";
                Console.WriteLine(sql);
                SqlCommand cmd = new SqlCommand(sql, Conectar());
                cmd.CommandTimeout = 0;
                resultado = cmd.ExecuteNonQuery();
                Desconectar();
            }
            catch (Exception ex)
            {
                resultado = 0;
                Console.WriteLine("Error en Eliminar TipoSeguro " + ex.Message);
                Desconectar();
            }
            return resultado;
        }
    }
}
