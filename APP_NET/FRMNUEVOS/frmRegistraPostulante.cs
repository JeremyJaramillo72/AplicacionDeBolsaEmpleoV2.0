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
namespace APP_NET.FRMNUEVOS
{
    public partial class frmRegistraPostulante : Form
    {
        public frmRegistraPostulante()
        {
            InitializeComponent();
        }

        private void btn_regiEmpre_Click(object sender, EventArgs e)
        {
            frmRegistroEmpresa frmE = new frmRegistroEmpresa();
            frmE.StartPosition = FormStartPosition.CenterScreen;
            frmE.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmLOGEAGOR frmLogin = new frmLOGEAGOR();
            frmLogin.StartPosition = FormStartPosition.CenterScreen;
            frmLogin.Show();
            this.Hide();
        }

        private void btn_registrarCandi_Click(object sender, EventArgs e)
        {
            bool verificador = false;
            try
            {
                string nombre = txtnombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string email = txtemail.Text.Trim();
                string Tele = txtTelefono.Text.Trim();
                string contraseña = txtcfmpassword.Text.Trim();
                string tipoUsers = cbtipoUsers.Text.Trim();
                string nombre_P = cbtipoUsers.SelectedItem.ToString();
                int id = 0;
                if (nombre_P == "Femenino")
                    id = 2;
                else
                    id = 1;


                csLogin verificar = new csLogin();
                csEncriptarMD5 Encriptar = new csEncriptarMD5();
                string Clave_Encriptada = Encriptar.Encriptar(contraseña, email);
                csUsers nuevoUsuario = new csUsers();
               (bool resultado ,string mensaje)= nuevoUsuario.AgregarUsuario(id, nombre, apellido, email, Tele, Clave_Encriptada, tipoUsers);
                MessageBox.Show(mensaje, resultado ? "Éxito" : "Error", MessageBoxButtons.OK, resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                txtnombre.Clear();
                txtApellido.Clear();
                txtemail.Clear();
                txtTelefono.Clear();
                txtcfmpassword.Clear();
                cbtipoUsers.Items.Clear();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
