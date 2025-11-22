using CAPA_NEGOCIO;
using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP_NET
{
    public partial class FrmCurriculum : Form
    {

        Publicaciones subir = new Publicaciones();
        string IdUsuario;
        string IdPublicacion;
        private OpenFileDialog openFileDialog;
        private string rutaArchivoCargado;
        public FrmCurriculum(string idUsuario, string idPublicacion)
        {
            InitializeComponent();
            InitializeComponents2();
            IdUsuario = idUsuario;
            IdPublicacion = idPublicacion;
        }
        private void InitializeComponents2()
        {
            this.Text = "Carga de Currículum";
            openFileDialog = new OpenFileDialog
            {
                Title = "Seleccionar Currículum",
                Filter = "Archivos de currículum (*.pdf;*.doc;*.docx)|*.pdf;*.doc;*.docx"
            };
            this.Controls.AddRange(new Control[]
            {

            btnCargarCurriculum,
            lblArchivoCargado,
            btnPostular
            });
        }


     
        private (string Estado, string Mensaje, string Ruta) ValidarCurriculum(string rutaArchivo)
        {
            string[] extensionesPermitidas = { ".pdf", ".doc", ".docx" };
            long maxTamano = 5 * 1024 * 1024; 

     
            string extension = Path.GetExtension(rutaArchivo).ToLower();
            if (!extensionesPermitidas.Contains(extension))
            {
                return ("error", "Formato de archivo no permitido. Use PDF, DOC o DOCX.", null);
            }

 
            FileInfo fileInfo = new FileInfo(rutaArchivo);
            if (fileInfo.Length > maxTamano)
            {
                return ("error", "El archivo excede el tamaño máximo permitido (5 MB).", null);
            }

            return ("exito", "Archivo válido", rutaArchivo);
        }

        private void btnCargarCurriculum_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
             
                    var resultado = ValidarCurriculum(openFileDialog.FileName);

                    if (resultado.Estado == "exito")
                    {
                        rutaArchivoCargado = resultado.Ruta;
                        lblArchivoCargado.Text = $"Archivo: {Path.GetFileName(resultado.Ruta)}";
                        lblArchivoCargado.ForeColor = Color.Green;
                    }
                    else
                    {
                        MessageBox.Show(resultado.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    

        private void btnPostular_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivoCargado))
            {
                MessageBox.Show("Por favor, cargue su currículum.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            (bool resultado, string mensaje) = subir.GuardarArchivoComoVarbinary(rutaArchivoCargado, IdUsuario, IdPublicacion);
            MessageBox.Show(mensaje, resultado ? "Éxito" : "Error", MessageBoxButtons.OK, resultado ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (mensaje == "Currículum enviado existosamente")
            {        
                this.Close();
            }
          
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnCargarCurriculum_Click_1(sender, EventArgs.Empty);
        }
    }
}
