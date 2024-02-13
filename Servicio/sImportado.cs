using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportesPadronNominal.Datos;
using ReportesPadronNominal.Entidad;
using System.Data;

namespace ReportesPadronNominal.Servicio
{
    class sImportado
    {

        //Objeto de la clase dImprotado
        dImportado objImportado = new dImportado();

        public int InsertarImportado(Eimportado objImpor)
        {
            return objImportado.InsertarImportado(objImpor);
        }
        public int EditarImportado(Eimportado objImpor)
        {
            return objImportado.EditarImportado(objImpor);
        }
        public int EliminarImportado(Eimportado objImpor)
        {
            return objImportado.EliminarImportado(objImpor);
        }
        public DataTable BuscarImportado(string nombre)
        {

            return objImportado.BuscarImportado(nombre);
        }
        public void ListarNominalesImportados(ref DataTable dt)
        {
            objImportado.ListarNominalesImportados(ref dt);
        }
        public void eliminarImortadoNominal(int anio, int mes)
        {
            objImportado.eliminarImortadoNominal(anio, mes);
        }
    }
}
