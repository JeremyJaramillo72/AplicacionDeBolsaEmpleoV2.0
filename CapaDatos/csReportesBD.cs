using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class csReportesBD
    {
        public csConexionSQL  conectar = new csConexionSQL();
        public DataTable ResumenPublicacionPorEmpleoPublicado(string fechaIni, string fechaFin, string estado)
        {
            DataTable dtProfesionales = new DataTable();
            try
            {
                conectar.AbrirConexion();
                using (SqlCommand cmd = new SqlCommand("PReporteNumeroEmpleosPublicados", conectar.Conexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@FechaInicio",  Convert.ToDateTime(fechaIni).Date);
                    cmd.Parameters.AddWithValue("@FechaFin", Convert.ToDateTime(fechaFin).Date);
                    cmd.Parameters.AddWithValue("@Estado", estado);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dtProfesionales);
                    }
                }
                conectar.CerrarConexion();
                return dtProfesionales;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los tratamientos: " + ex.Message);
            }
        }
    }
}
