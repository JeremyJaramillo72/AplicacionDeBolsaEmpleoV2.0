using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Windows.Forms;
using System.Data;

namespace CAPA_NEGOCIO
{
    public class Publicaciones
    {
        private csPublicacionBD datitot = new csPublicacionBD();
        string titulo;
        string descripcion;
        int añosExperiencia;
        int salarioMin;
        int salarioMax;
        int tipoPublicacion;
        int modalidad;
        int jornada;
        int provincia;
        int ciudad;
        int estado;

        public string Titulo { get => titulo; set => titulo = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int AñosExperiencia { get => añosExperiencia; set => añosExperiencia = value; }
        public int SalarioMin { get => salarioMin; set => salarioMin = value; }
        public int SalarioMax { get => salarioMax; set => salarioMax = value; }
        public int TipoPublicacion { get => tipoPublicacion; set => tipoPublicacion = value; }
        public int Modalidad { get => modalidad; set => modalidad = value; }
        public int Jornada { get => jornada; set => jornada = value; }
        public int Provincia { get => provincia; set => provincia = value; }
        public int Ciudad { get => ciudad; set => ciudad = value; }
        public int Estado { get => estado; set => estado = value; }



        public DataGridView ListaPublicacione(DataGridView dvgPublicaciones)
        {
            return datitot.LlenarDvgPublicacion(dvgPublicaciones);

        }
        public DataGridView ListaMisPublicacione(DataGridView dvgPublicacion, string id)
        {
            return datitot.LlenarDvgMisPublicacion(dvgPublicacion, id);
        }
        public DataGridView BuscarPublicacion(DataGridView dvgPublicaciones, string buscar)
        {
            return datitot.BuscarPublicacion(dvgPublicaciones, buscar);
        }
        public DataGridView MisPublicacionBuscar(DataGridView dvgPublicaciones, string buscar, string id)
        {
            return datitot.MisBuscarPublicacion(dvgPublicaciones, buscar, id);
        }
        public void AgregarComboBox(ComboBox categoria, ComboBox modalidad, ComboBox jornada, ComboBox ciudad)
        {
            datitot.AgregarComboBox(categoria, modalidad, jornada, ciudad);
        }
        public void AgregarComboBoxEstado(ComboBox Estado)
        {
            datitot.AgregarComboBoxEstado(Estado);
        }
        public DataGridView BuscarPublicacionComboBox(DataGridView dvgPublicaciones, string categoria, string modalidad, string jornada,string ciudad)
        {
            return datitot.BuscarPublicacionComboBox(dvgPublicaciones, categoria, modalidad, jornada,ciudad);
        }
        public DataGridView BuscarMisPublicacionComboBox(DataGridView dvgPublicaciones, string id,string categoria, string modalidad, string jornada,string ciudad)
        {
            return datitot.BuscarMisPublicacionComboBox(dvgPublicaciones,id,categoria,modalidad, jornada,ciudad);
        }
        public (bool, string) AgregarPublicacion(int id, string titulo, int categoria, int modalidad, int jornada, int ciudad, string descripcion, int experiencia, int salarioMin, int salarioMax)
        {
            return datitot.AgregarPublicacion( id, titulo, categoria, modalidad, jornada, ciudad, descripcion, experiencia, salarioMin, salarioMax);
        }
        public (bool, string) ModifcarPublicacion(int idPublicacion, string titulo, int categoria, int modalidad, int jornada, int ciudad, int estado, string descripcion, int experiencia, int salarioMin, int salarioMax)
        {
            return datitot.ModifcarPublicacion(idPublicacion, titulo, categoria, modalidad, jornada, ciudad, estado, descripcion, experiencia, salarioMin, salarioMax);
        }
        public (bool, string) GuardarArchivoComoVarbinary(string rutaArchivo,string IdUsuario,string IdPublicacion)
        {
            int IdU = Convert.ToInt32(IdUsuario);
            int IdP= Convert.ToInt32(IdPublicacion);
            return datitot.GuardarCurriculumPublicacion(rutaArchivo, IdU, IdP);
        }

        public (bool, string) EliminarPublicacion(string IdPublicacion)
        {
            int IDPublicacion = Convert.ToInt32(IdPublicacion);
            return datitot.EliminarPublicacionProcedure(IDPublicacion);
        }
    }
}
