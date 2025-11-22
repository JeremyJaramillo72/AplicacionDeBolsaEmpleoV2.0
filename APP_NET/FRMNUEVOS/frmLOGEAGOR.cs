using APP_NET.Formularios;
using CAPA_NEGOCIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace APP_NET.FRMNUEVOS
{
  
    public partial class frmLOGEAGOR : Form
    {
        csUsers usuario = new csUsers();
      
        public frmLOGEAGOR()
        {
            InitializeComponent();
        }
        public frmLOGEAGOR(string rol)
        {
         InitializeComponent();

        }

        private void btn_registraAhora_Click(object sender, EventArgs e)
        {
            frmRegistraPostulante frmP = new frmRegistraPostulante();
            frmP.StartPosition = FormStartPosition.CenterScreen;
            frmP.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           

            string rol= usuario.InicioDeSession(txtUsuario.Text, txtpassword.Text);
            MessageBox.Show(rol);   
            if (rol == "Profesional")
            {
               
                FrmMenu entrar = new FrmMenu(usuario.IdUsuario);
                entrar.Email1 = txtUsuario.Text;
                entrar.btnMisPublicaciones.Visible = false;
                entrar.BtnReportes.Visible = false;
                entrar.Show();
                this.Hide();
            }
           else  if (rol == "Administrador")
            {
                FrmMenu entrar = new FrmMenu(usuario.IdUsuario);
                entrar.Email1 = txtUsuario.Text;
                entrar.btnMisPublicaciones.Visible = false;
                entrar.btnConexion.Visible = false;
                entrar.BtnMensajes.Visible = false;
                entrar.btnMisPublicaciones.Visible = false;
                entrar.BtnEmpleo.Visible = false;
                entrar.btnPerfil.Visible = false;
                entrar.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Datos Ingresados Incorrectos, intente de nuevo.");
            }
        }
    }
}
