    using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using System.Runtime.InteropServices.WindowsRuntime;

namespace CapaDatos
{
    public class csPublicacionBD : csConexionSQL
    {
        ModifcarDatagridview Modificador = new ModifcarDatagridview();
        csdatos llenarCombox = new csdatos();
        private static DataTable registros = new DataTable();
        csConexionSQL conexion = new csConexionSQL();

        public csPublicacionBD()
        {

        }
        public DataGridView LlenarDvgPublicacion(DataGridView dvgPublicacion)
        {
            registros = conexion.MostrarRegistrosProcedure("PMostrar_Publicaciones");
            Modificador.Mostrar(dvgPublicacion, registros);
            return dvgPublicacion;
        }
        public DataGridView LlenarDvgMisPublicacion(DataGridView dvgPublicacion, string id)
        {
            registros = conexion.MostrarRegistrosProcedureMisPublicaciones("PMisPublicaciones", id);
            Modificador.Mostrar(dvgPublicacion, registros);
            return dvgPublicacion;
        }
        public DataGridView BuscarPublicacion(DataGridView dvgPublicaciones, string buscar)
        {

            dvgPublicaciones.Rows.Clear();
            registros = conexion.MostrarRegistrosProcedurePorParametro("PBuscarPublicaciones", buscar);
            Modificador.Mostrar(dvgPublicaciones, registros);
            return dvgPublicaciones;
        }
        public DataGridView MisBuscarPublicacion(DataGridView dvgPublicaciones, string buscar, string id)
        {

            dvgPublicaciones.Rows.Clear();
            registros = conexion.MostrarRegistrosProcedureMisPublicacionesPorTitulo("PMisPublicacionesBuscar", buscar, id);
            Modificador.Mostrar(dvgPublicaciones, registros);
            return dvgPublicaciones;
        }
        public void AgregarComboBox(ComboBox categoria, ComboBox modalidad, ComboBox jornada, ComboBox ciudad)
        {
            llenarCombox.llenarcmbProcedure(categoria, "PMostrarCategorias", "CategoriaPublicacion", "ID_Categoria_Publicacion");
            llenarCombox.llenarcmbProcedure(modalidad, "PMostrarModalidad", "Modalidad", "ID_Modalidad");
            llenarCombox.llenarcmbProcedure(jornada, "PMostrarJornada", "Jornada", "ID_Jornada");
            llenarCombox.llenarcmbProcedure(ciudad, "PVisualizarCiudades", "Nombre_Ciudad", "ID_Ciudad");
        }
        public void AgregarComboBoxEstado(ComboBox Estado)
        {
            llenarCombox.llenarcmbProcedure(Estado, "PVisualizarEstadoPublicacion", "TipoEstado", "ID_EstadoP");
        }
        public DataGridView BuscarMisPublicacionComboBox(DataGridView dvgPublicaciones, string id, string categoria, string modalidad, string jornada, string ciudad)
        {
            dvgPublicaciones.Rows.Clear();
            registros = conexion.MostrarRegistrosMisComboBox("PMisPublicaionesFiltro", id, categoria, modalidad, jornada, ciudad);
            Modificador.Mostrar(dvgPublicaciones, registros);
            return dvgPublicaciones;
        }
        public DataGridView BuscarPublicacionComboBox(DataGridView dvgPublicaciones,string categoria, string modalidad, string jornada,string ciudad)
        {
            dvgPublicaciones.Rows.Clear();
            registros = conexion.MostrarRegistrosComboBox("PBuscarPublicacionesPorFiltros", categoria, modalidad, jornada,ciudad);
            Modificador.Mostrar(dvgPublicaciones, registros);
            return dvgPublicaciones;
        }
        public (bool, string) AgregarPublicacion(int id, string titulo, int categoria, int modalidad, int jornada, int ciudad, string descripcion, int experiencia, int salarioMin, int salarioMax)
        {
            return conexion.RegistrarPublicacion(id, titulo, categoria, modalidad, jornada, ciudad, descripcion, experiencia, salarioMin, salarioMax);
        }
        public (bool, string) ModifcarPublicacion(int idPublicacion, string titulo, int categoria, int modalidad, int jornada, int ciudad, int estado, string descripcion, int experiencia, int salarioMin, int salarioMax)
        {
            return conexion.ModifcarPublicacion(idPublicacion, titulo, categoria, modalidad, jornada, ciudad, estado, descripcion, experiencia, salarioMin, salarioMax);
        }
        public (bool, string) GuardarCurriculumPublicacion(string rutaArchivo, int idUsuario, int idPublicacion)
        {
            return conexion.GuardarCurriculumPublicacionProcedure(rutaArchivo, idUsuario, idPublicacion);
        }
        public (bool, string) EliminarPublicacionProcedure(int IdPublicacion)
        {
           
            return conexion.EliminarPublicacion(IdPublicacion);
        }
    }
}