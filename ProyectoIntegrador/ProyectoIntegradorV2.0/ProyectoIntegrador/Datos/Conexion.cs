using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // Referencia a MySQL (se agrega como libreria)

namespace ProyectoIntegrador.Datos
{
    public class Conexion // la clase debe ser pública
    {

        // Declaración de variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null; // Se usará para el patrón Singleton

        // Constructor privado para evitar la creación de instancias fuera de la clase
        private Conexion()
        {
            // Asignamos los valores a las variables de la conexión
            this.baseDatos = "ProyectoGym"; 
            this.servidor = "localhost"; 
            this.puerto = "3306"; 
            this.usuario = "root";
            this.clave = "root";
        }

        // Método para crear y obtener la conexión
        public MySqlConnection CrearConexion()
        {
            MySqlConnection? cadena = new MySqlConnection();
            try
            {
                // Formamos la cadena de conexión usando las variables declaradas
                cadena.ConnectionString = "datasource=" + this.servidor +
                                          ";port=" + this.puerto +
                                          ";username=" + this.usuario +
                                          ";password=" + this.clave +
                                          ";Database=" + this.baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw; // Relanzamos el error
            }
            return cadena;
        }

        // Método estático para evaluar la instancia de la conexión
        public static Conexion getInstancia()
        {
            if (con == null) // Si la conexión no ha sido creada
            {
                con = new Conexion(); // Creamos una nueva instancia de la clase Conexion
            }
            return con;
        }






    }
}
