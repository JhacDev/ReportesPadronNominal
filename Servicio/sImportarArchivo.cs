using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReportesPadronNominal.Datos;
using System.Data;

namespace ReportesPadronNominal.Servicio
{
    class sImportarArchivo
    {
        dImportarArchivo objImportar = new dImportarArchivo();
        public int ImportarArchivoCSV(string ruta, string tabla)
        {
            return objImportar.ImportarArchivoCSV(ruta, tabla);
        }
        public DataTable TotalRegistro(string nombreTabla)
        {
            return objImportar.TotalRegistro(nombreTabla);
        }
        public void LimpiarTabla(string nombreTable)
        {
            objImportar.LimpiarTabla(nombreTable);
        }
        public int ImportarPadronNominal(string ruta, string tabla)
        {
            return objImportar.ImportarPadronNominal(ruta, tabla);
        }
        /*--------------------ACTUALIZAR TIPO DOCUMENTO CNV Y DNI--------------------------------------------*/

        //3. Actualizar Tipo de Documento Todos los pacientes que tiene Nro. Doc. DNI
        public int ActualizarDNI_PadronNominal()
        {
            return objImportar.ActualizarDNI_PadronNominal();
        }

        //4. Actualizar Tipo de Documento Todos los pacientes que tiene Nro. Doc. CNV
        public int ActualizarCNV_PadronNominal()
        {
            return objImportar.ActualizarCNV_PadronNominal();
        }

        //5. Agregar codigo CNV a DNI
        public int AgregarCNV_DNI_PadronNominal()
        {
            return objImportar.ActualizarDNI_PadronNominal();
        }
        /*-----------------------QUERY ELIMINAR TIPODICUMENTO Y TIPO SEGURO-----------------------------------------*/

        //6. Eliminar Todos los personal con Tipo Documento CUI Y PN
        public int Eliminar_CUI_PN_PadronNominal()
        {
            return objImportar.Eliminar_CUI_PN_PadronNominal();
        }

        //7. Eliminar todos los personas con tipo de seguro ESSALUD,PRIVADO
        public int EliminarTipoSeguro_ESSALUD_PRIVADO_PadronNominal()
        {
            return objImportar.EliminarTipoSeguro_ESSALUD_PRIVADO_PadronNominal();
        }
    }
}
