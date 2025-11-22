using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDatos
{
    public class csUsuariosBD :csConexionSQL
    {
        public (bool,string) AgregarUsuario(int Id, string Nombre, string Apellido, string CorreoElectronico, string Telefono, string Contra, string Genero_usuario)
        {
            try
            {
                Conexion.Open();
          
                SqlCommand cmdUsuario = new SqlCommand("InsertarProfessional/Administrador", Conexion);
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.Parameters.AddWithValue("@Rol", 1);
                cmdUsuario.Parameters.AddWithValue("@Nombre", Nombre);
                cmdUsuario.Parameters.AddWithValue("@Apellido", Apellido);
                cmdUsuario.Parameters.AddWithValue("@Correo", CorreoElectronico);
                cmdUsuario.Parameters.AddWithValue("@Contraseña", Contra);
                cmdUsuario.Parameters.AddWithValue("@Telefono", Telefono);
                cmdUsuario.Parameters.AddWithValue("@Genero", Genero_usuario);
                cmdUsuario.Parameters.AddWithValue("@IDImagen", Id);

                SqlParameter resultadoParam = new SqlParameter("@Resultado", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                SqlParameter mensajeRetornoParam = new SqlParameter("@MensajeRetorno", SqlDbType.NVarChar, 50) { Direction = ParameterDirection.Output };
                cmdUsuario.Parameters.Add(resultadoParam);
                cmdUsuario.Parameters.Add(mensajeRetornoParam);

                cmdUsuario.ExecuteNonQuery();
                Conexion.Close();
                return (Convert.ToBoolean(resultadoParam.Value), mensajeRetornoParam.Value.ToString());

                
              
            }
            catch (Exception ex)
            {
                return (false, $"Error al guardar el usuario: {ex.Message}");

            }

        }
    }
}
