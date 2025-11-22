using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;
using CapaDatos;

namespace APP_NET
{
     
    public partial class FrmReportes : Form
    {
         csReportes reporte = new csReportes();
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {

            this.RpViewer.RefreshReport();
            
        }

        private void cmbReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReporte.SelectedIndex==0)
            {
                reporte.ReporteResumenPublicacionPorParametros(RpViewer, "2024-01-01", "2025-03-26", "Abierta");
                RpViewer.RefreshReport();
            }
        }
    }
}
