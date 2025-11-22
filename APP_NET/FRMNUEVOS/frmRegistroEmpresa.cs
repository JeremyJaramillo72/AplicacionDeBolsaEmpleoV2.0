using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_NET.FRMNUEVOS
{
    public partial class frmRegistroEmpresa : Form
    {
        public frmRegistroEmpresa()
        {
            InitializeComponent();
        }

        private void btn_regCandi_Click(object sender, EventArgs e)
        {
            frmRegistraPostulante frmP = new frmRegistraPostulante();
            frmP.StartPosition = FormStartPosition.CenterScreen;
            frmP.Show();
            this.Hide();
        }

        private void Btn_Inicia_Click(object sender, EventArgs e)
        {
            frmLOGEAGOR frmlogin = new frmLOGEAGOR();
            frmlogin.StartPosition = FormStartPosition.CenterScreen;
            frmlogin.Show();
            this.Hide();
        }

        private void btn_registrarEmpresa_Click(object sender, EventArgs e)
        {

        }
    }
}
