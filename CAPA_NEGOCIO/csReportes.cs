using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using CapaDatos;

namespace CAPA_NEGOCIO
{
    public class csReportes
    {
        csReportesBD reportesBD = new csReportesBD();
        public void ReporteResumenPublicacionPorParametros(ReportViewer reporte, string fechaIni, string fechaFin, string estado)
        {
            reporte.LocalReport.DataSources.Clear();
            ReportDataSource DatosReporte = new ReportDataSource();
            DataTable tabla = reportesBD.ResumenPublicacionPorEmpleoPublicado(fechaIni, fechaFin, estado);
            reporte.LocalReport.ReportEmbeddedResource = "CAPA_NEGOCIO.RptVisualizarPublicacionesFecha.rdlc";
            try { DatosReporte = new ReportDataSource("DsReportesPublicacionesPorParametroFecha"); }
            catch { }
            reporte.LocalReport.DataSources.Add(DatosReporte);
            DatosReporte.Value = tabla;
            reporte.LocalReport.Refresh();
        }
    }
}
