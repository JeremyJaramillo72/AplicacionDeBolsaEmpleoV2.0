using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace APP_NET
{
    public partial class FrmMisPublicaciones : Form
    {
        public string id; public string IdPublicacion;
        Publicaciones publicar = new Publicaciones();
        public FrmMisPublicaciones()
        {
            InitializeComponent();
        }
        public FrmMisPublicaciones(string x)
        {

            InitializeComponent();
            id=x;
        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscador.Text.Length >= 3)
            {
                publicar.MisPublicacionBuscar(dgvMisPublicaciones, txtBuscador.Text,id);
            }
            else
            {
                dgvMisPublicaciones.Rows.Clear();
                publicar.ListaMisPublicacione(dgvMisPublicaciones, id);
            }
        }

        private void FrmMisPublicaciones_Load(object sender, EventArgs e)
        {
          
            publicar.ListaMisPublicacione(dgvMisPublicaciones,id);
            publicar.AgregarComboBox(cmbCategoria, cmbModalidad, cmbJornada,cmbCiudad);
            cmbCiudad.MaxDropDownItems = 5;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string categoria = (cmbCategoria.SelectedItem as DataRowView)?["CategoriaPublicacion"].ToString();
            string modalidad = (cmbModalidad.SelectedItem as DataRowView)?["Modalidad"].ToString();
            string jornada = (cmbJornada.SelectedItem as DataRowView)?["Jornada"].ToString();
            string ciudad = (cmbCiudad.SelectedItem as DataRowView)?["Nombre_Ciudad"].ToString();
                publicar.BuscarMisPublicacionComboBox(dgvMisPublicaciones, id,categoria, modalidad, jornada, ciudad);        
        }

        private void btnAgregarPublicacion_Click(object sender, EventArgs e)
        {
            FrmAgregarPublicacion frm =new FrmAgregarPublicacion(id);
            this.AddOwnedForm(frm);
            frm.ShowDialog();
        }

        private void cmbCiudad_DropDown(object sender, EventArgs e)
        {
            cmbCiudad.DropDownHeight = cmbCiudad.ItemHeight * 5;
        }

        private void cmbCiudad_DropDown_1(object sender, EventArgs e)
        {
            cmbCiudad.DropDownHeight = cmbCiudad.ItemHeight * 5;
        }

        private void dgvMisPublicaciones_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string IdPublicacion = dgvMisPublicaciones.Rows[e.RowIndex].Cells[0].Value.ToString();
            FrmModificarPublicacion frm = new FrmModificarPublicacion(id,IdPublicacion);
            this.AddOwnedForm(frm);
            publicar.AgregarComboBox(frm.cmbCategoria, frm.cmbModalidad, frm.cmbJornada, frm.cmbCiudad);
            publicar.AgregarComboBoxEstado(frm.cmbEstadoPublicacion);
            frm.btnTitulo.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[1].Value.ToString();
            frm.cmbCategoria.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[3].Value.ToString();
            frm.cmbModalidad.Text =dgvMisPublicaciones.Rows[e.RowIndex].Cells[4].Value.ToString();
            frm.cmbJornada.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[5].Value.ToString();
            frm.cmbCiudad.Text= dgvMisPublicaciones.Rows[e.RowIndex].Cells[6].Value.ToString();
            frm.cmbEstadoPublicacion.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[7].Value.ToString();
            frm.btnDescripcion.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[8].Value.ToString();
            frm.BtnSalarioMinimo.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[10].Value.ToString();
            frm.btnSalarioMax.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[11].Value.ToString();
            frm.btnExperiencia.Text = dgvMisPublicaciones.Rows[e.RowIndex].Cells[13].Value.ToString();
            frm.ShowDialog();
        }

        private void bordes_Boton1_Click(object sender, EventArgs e)
        {

            (bool resultado, string mensaje) = publicar.EliminarPublicacion(IdPublicacion);
            MessageBox.Show(mensaje, resultado ? "Éxito" : "Error", MessageBoxButtons.OK, resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (mensaje == "Publicacion Eliminada Existosamente")
            {
                dgvMisPublicaciones.Rows.Clear();
                publicar.ListaMisPublicacione(dgvMisPublicaciones, id);               
            }
        }

        private void dgvMisPublicaciones_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dgvMisPublicaciones.SelectedRows.Count > 0)
            {        
                DataGridViewRow filaSeleccionada = dgvMisPublicaciones.SelectedRows[0];          
                IdPublicacion = filaSeleccionada.Cells["Codigo"].Value.ToString();             
            }
        }

        private void guna2PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            cmbCategoria.SelectedIndex = -1;
            cmbCiudad.SelectedIndex = -1;
            cmbJornada.SelectedIndex = -1;
            cmbModalidad.SelectedIndex = -1;
            txtBuscador.Text = null;
            dgvMisPublicaciones.Rows.Clear();
            publicar.ListaMisPublicacione(dgvMisPublicaciones, id);
        }
    }
}
