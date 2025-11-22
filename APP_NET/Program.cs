using APP_NET.FRMNUEVOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_NET
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new FrmCurriculum());
            //Application.Run(new GestionInicio());
            Application.Run(new frmLOGEAGOR());
            //Application.Run(new MensaJS());
            //Application.Run(new FrmConexion());
        }
    }
}
