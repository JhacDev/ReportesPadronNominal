
namespace ReportesPadronNominal.Vista
{
    partial class frmImportar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportar));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.panelMensaje = new System.Windows.Forms.Panel();
            this.lblMensajeA = new System.Windows.Forms.Label();
            this.pbIconoMensaje = new System.Windows.Forms.PictureBox();
            this.lblFechaImportePN = new System.Windows.Forms.Label();
            this.lblTotalRegPadron = new System.Windows.Forms.Label();
            this.lblRutaPadronA = new System.Windows.Forms.Label();
            this.btnPadronNomial = new System.Windows.Forms.Button();
            this.pbIconLimpiarPN = new System.Windows.Forms.PictureBox();
            this.pbIconAvisoPN = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.panelMensaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoMensaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconLimpiarPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconAvisoPN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1050, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "IMPORTACIÓN DE ARCHIVOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(1020, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(25, 25);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSalir.TabIndex = 4;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelMensaje
            // 
            this.panelMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.panelMensaje.Controls.Add(this.lblMensajeA);
            this.panelMensaje.Controls.Add(this.pbIconoMensaje);
            this.panelMensaje.ForeColor = System.Drawing.Color.Red;
            this.panelMensaje.Location = new System.Drawing.Point(171, 55);
            this.panelMensaje.Name = "panelMensaje";
            this.panelMensaje.Size = new System.Drawing.Size(756, 106);
            this.panelMensaje.TabIndex = 83;
            this.panelMensaje.Visible = false;
            // 
            // lblMensajeA
            // 
            this.lblMensajeA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.lblMensajeA.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMensajeA.Font = new System.Drawing.Font("Century Gothic", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeA.ForeColor = System.Drawing.Color.White;
            this.lblMensajeA.Location = new System.Drawing.Point(95, 0);
            this.lblMensajeA.Name = "lblMensajeA";
            this.lblMensajeA.Size = new System.Drawing.Size(661, 106);
            this.lblMensajeA.TabIndex = 1;
            this.lblMensajeA.Text = "Importado correctamente";
            this.lblMensajeA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbIconoMensaje
            // 
            this.pbIconoMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.pbIconoMensaje.Image = ((System.Drawing.Image)(resources.GetObject("pbIconoMensaje.Image")));
            this.pbIconoMensaje.Location = new System.Drawing.Point(3, 21);
            this.pbIconoMensaje.Name = "pbIconoMensaje";
            this.pbIconoMensaje.Size = new System.Drawing.Size(82, 70);
            this.pbIconoMensaje.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconoMensaje.TabIndex = 0;
            this.pbIconoMensaje.TabStop = false;
            // 
            // lblFechaImportePN
            // 
            this.lblFechaImportePN.AutoSize = true;
            this.lblFechaImportePN.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaImportePN.ForeColor = System.Drawing.Color.Black;
            this.lblFechaImportePN.Location = new System.Drawing.Point(169, 57);
            this.lblFechaImportePN.Name = "lblFechaImportePN";
            this.lblFechaImportePN.Size = new System.Drawing.Size(130, 19);
            this.lblFechaImportePN.TabIndex = 85;
            this.lblFechaImportePN.Text = "Fecha Importe :";
            // 
            // lblTotalRegPadron
            // 
            this.lblTotalRegPadron.AutoSize = true;
            this.lblTotalRegPadron.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRegPadron.ForeColor = System.Drawing.Color.Black;
            this.lblTotalRegPadron.Location = new System.Drawing.Point(169, 82);
            this.lblTotalRegPadron.Name = "lblTotalRegPadron";
            this.lblTotalRegPadron.Size = new System.Drawing.Size(116, 19);
            this.lblTotalRegPadron.TabIndex = 86;
            this.lblTotalRegPadron.Text = "Total Registro :";
            // 
            // lblRutaPadronA
            // 
            this.lblRutaPadronA.AutoSize = true;
            this.lblRutaPadronA.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRutaPadronA.ForeColor = System.Drawing.Color.Black;
            this.lblRutaPadronA.Location = new System.Drawing.Point(169, 106);
            this.lblRutaPadronA.Name = "lblRutaPadronA";
            this.lblRutaPadronA.Size = new System.Drawing.Size(144, 19);
            this.lblRutaPadronA.TabIndex = 87;
            this.lblRutaPadronA.Text = "Ruta del Archivo :";
            // 
            // btnPadronNomial
            // 
            this.btnPadronNomial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(55)))), ((int)(((byte)(83)))));
            this.btnPadronNomial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPadronNomial.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPadronNomial.ForeColor = System.Drawing.Color.White;
            this.btnPadronNomial.Image = ((System.Drawing.Image)(resources.GetObject("btnPadronNomial.Image")));
            this.btnPadronNomial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPadronNomial.Location = new System.Drawing.Point(12, 50);
            this.btnPadronNomial.Name = "btnPadronNomial";
            this.btnPadronNomial.Size = new System.Drawing.Size(155, 111);
            this.btnPadronNomial.TabIndex = 84;
            this.btnPadronNomial.Text = "    Padron \r\n    Nominal";
            this.btnPadronNomial.UseVisualStyleBackColor = false;
            this.btnPadronNomial.Click += new System.EventHandler(this.btnPadronNomial_Click);
            // 
            // pbIconLimpiarPN
            // 
            this.pbIconLimpiarPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIconLimpiarPN.Image = ((System.Drawing.Image)(resources.GetObject("pbIconLimpiarPN.Image")));
            this.pbIconLimpiarPN.Location = new System.Drawing.Point(954, 59);
            this.pbIconLimpiarPN.Name = "pbIconLimpiarPN";
            this.pbIconLimpiarPN.Size = new System.Drawing.Size(27, 39);
            this.pbIconLimpiarPN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconLimpiarPN.TabIndex = 88;
            this.pbIconLimpiarPN.TabStop = false;
            // 
            // pbIconAvisoPN
            // 
            this.pbIconAvisoPN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbIconAvisoPN.Image = ((System.Drawing.Image)(resources.GetObject("pbIconAvisoPN.Image")));
            this.pbIconAvisoPN.Location = new System.Drawing.Point(990, 59);
            this.pbIconAvisoPN.Name = "pbIconAvisoPN";
            this.pbIconAvisoPN.Size = new System.Drawing.Size(27, 39);
            this.pbIconAvisoPN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIconAvisoPN.TabIndex = 89;
            this.pbIconAvisoPN.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip1.ToolTipTitle = "Aviso!";
            // 
            // frmImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.pbIconLimpiarPN);
            this.Controls.Add(this.pbIconAvisoPN);
            this.Controls.Add(this.panelMensaje);
            this.Controls.Add(this.lblFechaImportePN);
            this.Controls.Add(this.lblTotalRegPadron);
            this.Controls.Add(this.lblRutaPadronA);
            this.Controls.Add(this.btnPadronNomial);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmImportar";
            this.Text = "frmImportar";
            this.Load += new System.EventHandler(this.frmImportar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.panelMensaje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbIconoMensaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconLimpiarPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIconAvisoPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.Panel panelMensaje;
        private System.Windows.Forms.Label lblMensajeA;
        private System.Windows.Forms.PictureBox pbIconoMensaje;
        private System.Windows.Forms.Label lblFechaImportePN;
        private System.Windows.Forms.Label lblTotalRegPadron;
        private System.Windows.Forms.Label lblRutaPadronA;
        private System.Windows.Forms.Button btnPadronNomial;
        private System.Windows.Forms.PictureBox pbIconLimpiarPN;
        private System.Windows.Forms.PictureBox pbIconAvisoPN;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}