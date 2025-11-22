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
using System.Web.UI.WebControls;
using System.Windows.Forms;
using APP_NET.Clases;
using APP_NET.Formularios;
using CapaDatos;
using Guna.UI2.WinForms.Suite;
using static System.Windows.Forms.MonthCalendar;

namespace APP_NET
{
    public partial class Perfil_Pro : Form
    {
        string ID;
        csConexionSQL dato = new csConexionSQL();
        csdatos dt = new csdatos();
        string IDT;

        public static int año;
        public static string Descripcion;
        public static int ID_Area;
        public static int ID_Idioma;
        public static int ID_Ciudad;
        public static int Id_Titulo;
        public Perfil_Pro(string x)
        {
            InitializeComponent();
            ID = x;
            Imagen mi = new Imagen();
            mi.MostrarLogoNombre(x, Ft_Perfil);
        }

        private void Perfil_Pro_Load(object sender, EventArgs e)
        {
            MASOPTIMO();

            if (dato.VerificarInformacionUsuario(int.Parse(ID)))
            {
                btnguardar.Text = "Actualizar";

                Users.DataSource = dato.MostrarRegistros($@"
                        SELECT 
                            pa.ID_Perfil,
                            P.ID_Usuario, 
                            P.ID_Ciudad, 
                            C.ID_Provincia,
                            P.Años_Experiencia, 
                            P.Descripcion_Personal,
                            t.Nombre_Titulo,
                            A.Nombre_Area
                        FROM 
                            Perfil_Profesional P 
                        INNER JOIN 
                            Ciudad C ON C.ID_Ciudad = P.ID_Ciudad
                        INNER JOIN 
                            Perfil_Area pa ON pa.ID_Perfil = P.ID_Perfil
                        INNER JOIN 
                            Tipo_Area A ON pa.ID_Area = A.ID_Area 
                        INNER JOIN 
                            Tipo_Titulo t ON t.ID_Titulo = A.ID_Titulo
                        WHERE 
                            P.ID_Usuario = {ID}");

                if (Users.Rows.Count > 0)
                {
                    txtaño.Text = Users.Rows[0].Cells["Años_Experiencia"].Value.ToString();
                    cmbProvincia.SelectedValue = Users.Rows[0].Cells["ID_Provincia"].Value.ToString();
                    richTextBox1.Text = Users.Rows[0].Cells["Descripcion_Personal"].Value?.ToString();
                    cmbCiudad.SelectedValue = Users.Rows[0].Cells["ID_Ciudad"].Value.ToString();
                    // Asignar los valores de los nuevos campos
                    gncmbTitulo.Text = Users.Rows[0].Cells["Nombre_Titulo"].Value?.ToString();
                    gncmbArea.Text = Users.Rows[0].Cells["Nombre_Area"].Value?.ToString();
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el usuario.");
                }
            }
        }
        private void bordes_Boton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog Imagen = new OpenFileDialog();
            Imagen.Filter = "archivos de imagen (*.png)|*.png;";
            if (Imagen.ShowDialog() == DialogResult.OK)
            {
                Ft_Perfil.BackgroundImage = null;
                Ft_Perfil.Image = null;

                Ft_Perfil.Image = System.Drawing.Image.FromFile(Imagen.FileName);
                new Imagen().GuardarImagen(Ft_Perfil, "INSERT INTO Imagen(Imagen) VALUES(@imagen)");

                string IdUltimo = "SELECT MAX(ID_Imagen) AS ID_MAX FROM Imagen";
                string idMaximo = dato.Extraer(IdUltimo, "ID_MAX");
                string cadena2 = "UPDATE Usuario_Imagen SET ID_Imagen = '" + idMaximo + "' WHERE ID_Usuario = '" + ID + "'";
                dato.Insert(cadena2);

                if (this.Owner is FrmMenu frmMenu)
                {
                    frmMenu.ImgPerfil.Image = null;
                    frmMenu.ImgPerfil.Image = Ft_Perfil.Image;
                    frmMenu.ImgPerfil.Refresh();
                }
            }
        }
        private void bordes_Boton4_Click(object sender, EventArgs e)
        {

            if (btnguardar.Text == "Guardar")
            {
                // Verificar si todos los campos están completos
                if (string.IsNullOrWhiteSpace(txtaño.Text) || string.IsNullOrWhiteSpace(richTextBox1.Text) ||
                    gncmbTitulo.SelectedValue == null || 
                    cmbProvincia.SelectedValue == null || gncmbArea.SelectedValue == null || cmbCiudad.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, completa todos los campos antes de guardar.");
                    return;
                }
                else
                {
                    int año = int.Parse(txtaño.Text);
                    string Descripcion = richTextBox1.Text;
                    int ID_Ciudad = int.Parse(cmbCiudad.SelectedValue.ToString());
                    int ID_Area = int.Parse(gncmbArea.SelectedValue.ToString()); // Obtener el ID del área
                    string ID_Usuario = ID;

                    // Insertar en la tabla Perfil_Profesional
                    dato.Insert($"insert into Perfil_Profesional (ID_Usuario, Años_Experiencia, Descripcion_Personal, ID_Ciudad) " +
                                $"values ({ID_Usuario}, {año}, '{Descripcion}', {ID_Ciudad})");

                    // Obtener el ID máximo de la tabla Perfil_Profesional para el perfil recién insertado
                    string query = "SELECT MAX(ID_Perfil) as ID_MAX FROM Perfil_Profesional";
                    string idMaximo = dato.Extraer(query, "ID_MAX");

                    // Insertar en la tabla Perfil_Area
                    dato.Insert($"insert into Perfil_Area (ID_Perfil, ID_Area) values ({idMaximo}, {ID_Area})");

                    // Ahora vamos a insertar los idiomas seleccionados
                    foreach (Control control in check.Controls)
                    {
                        if (control is System.Windows.Forms.CheckBox chk && chk.Checked)
                        {
                            int ID_Idioma = Convert.ToInt32(chk.Tag);  // Obtener el ID del idioma seleccionado
                            MessageBox.Show(ID_Idioma.ToString());
                            // Insertar el ID_Perfil y el ID_Idioma en la tabla Perfil_Profesional__Tipo_Idioma
                            dato.Insert($"insert into Perfil_Profesional__Tipo_Idioma (ID_Perfil, ID_Idioma) values ({idMaximo}, {ID_Idioma})");
                        }
                    }

                    // Mensaje de éxito
                    MessageBox.Show("¡Registro guardado exitosamente!");

                    // Limpiar los campos
                    txtaño.Clear();
                    richTextBox1.Clear();
                    cmbProvincia.SelectedIndex = -1;
                    gncmbArea.SelectedIndex = -1;
                    cmbCiudad.SelectedIndex = -1;

                    // Limpiar los CheckBox seleccionados
                    foreach (Control control in check.Controls)
                    {
                        if (control is System.Windows.Forms.CheckBox chk)
                        {
                            chk.Checked = false;  // Desmarcar todos los CheckBox
                        }
                    }

                }
            }
            else 
            {
                if (string.IsNullOrWhiteSpace(txtaño.Text) || string.IsNullOrWhiteSpace(richTextBox1.Text) || gncmbTitulo.SelectedValue == null ||
                    cmbProvincia.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, completa todos los campos antes de guardar.");
                    return;
                }
                else
                {
                    año = int.Parse(txtaño.Text);
                    Descripcion = richTextBox1.Text;
                    ID_Area = int.Parse(gncmbArea.SelectedValue.ToString());
                    //ID_Idioma = int.Parse(gncmbIdioma.SelectedValue.ToString());
                    ID_Ciudad = int.Parse(cmbCiudad.SelectedValue.ToString());
                    // Actualizar Perfil_Profesional
                    dato.Insert($"update Perfil_Profesional set  Años_Experiencia={año}, Descripcion_Personal='{Descripcion}', ID_Ciudad={ID_Ciudad} where ID_Usuario={ID}");
                    MessageBox.Show("¡Registros Actualizado exitosamente");
                    
                }

            }
        }

        private void gncmbTitulo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dt.llenarcmb(gncmbArea, $"select * from Tipo_Area where ID_Titulo= {gncmbTitulo.SelectedValue.ToString()}", "Nombre_Area", "ID_Area");
        }
        private void cmbProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string c = cmbProvincia.SelectedValue.ToString();
            dt.llenarcmb(cmbCiudad, $"select * from Ciudad where ID_Provincia = {c}", "Nombre_Ciudad", "ID_Ciudad");
        }

        public void MASOPTIMO()
        {
            Users.Visible = false;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;

            dt.llenarcmb(gncmbTitulo, "select *from Tipo_Titulo", "Nombre_Titulo", "ID_Titulo");
           // dt.llenarcmb(gncmbIdioma, "select * from Tipo_Idioma", "Nombre_Idioma", "ID_Idioma");
            dt.llenarcmb(cmbProvincia, "select * from Provincia", "Nombre_Provincia", "ID_Provincia");

            dt.llenarlista(check, "select * from Tipo_Idioma", "Nombre_Idioma", "ID_Idioma");
        }

        private void btn_AREAS_Click(object sender, EventArgs e)
        {
            if (gncmbTitulo.SelectedIndex != -1 && gncmbArea.SelectedIndex != -1)
            {
             
                ID_Area = int.Parse(gncmbArea.SelectedValue.ToString());
                string query = "SELECT MAX(ID_Perfil) as ID_MAX FROM Perfil_Profesional";
                string idMaximo = dato.Extraer(query, "ID_MAX");
                dato.Insert($"insert into Perfil_Area (ID_Perfil, ID_Area) values ({idMaximo}, {ID_Area})");
                MessageBox.Show("¡Registro guardado exitosamente!");
                gncmbArea.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un Título y un Área.");
            }
        }
    }
}
