using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ReportesPadronNominal.Servicio;
using ReportesPadronNominal.Entidad;

namespace ReportesPadronNominal.Vista
{
    public partial class frmImportar : Form
    {
        //Objeto de la clase ImportadoBL
        sImportado objImportado = new sImportado();
        sImportarArchivo objArchivo = new sImportarArchivo();
            
        public frmImportar()
        {
            InitializeComponent();
        }
        string fechaImportado = null;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private string BuscarImportado(string nombre)
        {
            string valor = null;
            DataTable dt = objImportado.BuscarImportado(nombre);
            if (dt.Rows.Count > 0)
            {
                valor = dt.Rows[0][2].ToString();
                fechaImportado = DateTime.Parse(dt.Rows[0][3].ToString()).ToShortDateString();
            }
            return valor;
        }
        private int InsertarImportado(string nombre, string ruta)
        {
            Eimportado ojbEimportado = new Eimportado();
            ojbEimportado.nombre = nombre;
            ojbEimportado.ruta = ruta;
            int res = objImportado.InsertarImportado(ojbEimportado);
            return res;
        }
        int total(string Tabla)
        {
            int total = 0;
            DataTable dt = objArchivo.TotalRegistro(Tabla);
            if (dt.Rows.Count > 0)
            {
                total = int.Parse(dt.Rows[0].ItemArray[0].ToString());
            }
            return total;
        }
        void ActualizarRutaPadron()
        {
            string rutaPaciente = BuscarImportado("Padron_Nominal");
            if (rutaPaciente != null)
            {
                lblRutaPadronA.Text = "Ruta del Archivo : " + BuscarImportado("Padron_Nominal");
                lblFechaImportePN.Text = "Fecha Importado : " + fechaImportado;
                pbIconAvisoPN.Image = Properties.Resources.comprobado;
                lblTotalRegPadron.Text = "Total Registro : " + total("Padron_Nominal").ToString();
            }
            else
            {
                lblRutaPadronA.Text = "Ruta del Archivo : Archivo no encontrado";
                pbIconAvisoPN.Image = Properties.Resources.boton_x;
                lblTotalRegPadron.Text = "Total Registro : 0";
            }
        }


        private void btnPadronNomial_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "Archivo de texto |*.txt";
                of.Title = "Abrir Padron Nominal";
                if (of.ShowDialog() == DialogResult.OK)
                {
                    lblRutaPadronA.Text = of.FileName;
                    string nombreTabla = "Padron_Nominal";
                    string ruta = of.FileName;
                    sImportarArchivo objImportar = new sImportarArchivo();

                    //limpiar padron nominal
                    objImportar.LimpiarTabla(nombreTabla);
                    //importar nuevo archivo
                    int res = objImportar.ImportarPadronNominal(ruta, nombreTabla);

                    //registro nombre archivo importado
                    sImportado objArchivoImportado = new sImportado();
                    Eimportado objEimportado = new Eimportado();
                    objEimportado.ruta = ruta;
                    objEimportado.nombre = nombreTabla;

                    objArchivoImportado.InsertarImportado(objEimportado);

                    if (res > 0)
                    {
                        objImportar.ActualizarDNI_PadronNominal();
                        objImportar.ActualizarCNV_PadronNominal();
                        objImportar.AgregarCNV_DNI_PadronNominal();
                        //objImportar.Eliminar_CUI_PN_PadronNominal();
                        objImportar.EliminarTipoSeguro_ESSALUD_PRIVADO_PadronNominal();
                        ActualizarRutaPadron();
                        lblMensajeA.Text = "Padron Nominado Importado correctamente. !";
                        panelMensaje.Visible = true;
                        panelMensaje.BackColor = Color.FromArgb(13, 55, 83);
                        lblMensajeA.ForeColor = Color.Black;
                        //pbIconAvisoCNV.Image = Properties.Resources.voto_positivo;
                        panelMensaje.Location = new Point(171, 55);
                        timer1.Enabled = true;
                        timer1.Start();
                        //MessageBox.Show(res + " Padron Nominal Importado Correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al Importar, Padron Nominal: \n " + ex, "Error de Importacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmImportar_Load(object sender, EventArgs e)
        {
            
           //ActualizarRutaPadron();
           
        }
        int contador_segundos = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            contador_segundos += 3;
            if (contador_segundos >= 8)
            {
                panelMensaje.Visible = false;
                timer1.Stop();
                timer1.Enabled = false;


            }
        }
    }
}
