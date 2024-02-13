using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportesPadronNominal.Entidad
{
    class Eimportado
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _ruta;

        public string ruta
        {
            get { return _ruta; }
            set { _ruta = value; }
        }
    }
}
