using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_NET
{
    public partial class FrmMostrarContenidoPublicacion : Form
    {
        public string IdPublicacion; public string IdUsuario;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FrmMostrarContenidoPublicacion(string id)
        {
            InitializeComponent();
            IdUsuario = id;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
           this.Hide();
        }

        private void FrmMostrarContenidoPublicacion_Load(object sender, EventArgs e)
        {
            this.MouseDown += FrmMostrarContenidoPublicacion_MouseDown;
        }

        private void FrmMostrarContenidoPublicacion_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) 
            {
                ReleaseCapture();  
                SendMessage(this.Handle, 0x112, 0xf012, 0);
            }
        }

        private void btnPostular_Click(object sender, EventArgs e)
        {
            FrmCurriculum frm = new FrmCurriculum(IdUsuario,IdPublicacion);
            this.AddOwnedForm(frm);
            frm.ShowDialog();
           
        }
    }
}
