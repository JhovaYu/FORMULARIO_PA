using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FORMULARIO_PA
{
    internal class ConexionBD
    {
        private string connectionString;

        public ConexionBD() 
        {
            connectionString = "server=localhost;" +
                                "database=programacionavanzada;" +
                                "uid=root;" +
                                "pwd=#Sincodigo1;";
        }

        public MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Conexion establecida");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
            return connection;
        }

        public void InsertarRegistro(string nombre, string apellidos, string telefono, int edad, decimal estatura, string genero)
        {
            MySqlConnection connection = GetConnection();
            if(connection.State == System.Data.ConnectionState.Open)
            {
                string insertQuery = "INSERT INTO registros (Nombre, Apellidos, Edad, Estatura, Telefono, Genero)" +
                                 "VALUES (@Nombre, @Apellidos, @Edad, @Estatura, @Telefono, @Genero)";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Nombre", nombre);
                        command.Parameters.AddWithValue("@Apellidos", apellidos);
                        command.Parameters.AddWithValue("@Telefono", telefono);
                        command.Parameters.AddWithValue("@Edad", edad);
                        command.Parameters.AddWithValue("@Estatura", estatura);
                        command.Parameters.AddWithValue("@Genero", genero);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Registro Exitoso");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al insertar registro: " + ex.Message);
                }
                finally
                {
                    CloseConnection(connection);
                }
            }
        }

        public void CloseConnection(MySqlConnection connection)
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Conexion Cerrada");
            }
        }
    }
}
