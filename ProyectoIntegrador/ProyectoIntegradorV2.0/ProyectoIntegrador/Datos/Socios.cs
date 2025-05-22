using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.Entidades;
using MySql.Data.MySqlClient;


namespace ProyectoIntegrador.Datos
{
    internal class Socios
    {
        public string Nuevo_Socio(E_Socio soc)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros que vienen desde E_Socio (hereda de E_Cliente)
                comando.Parameters.Add("Docu", MySqlDbType.Int32).Value = soc.Doc; 
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = soc.TDoc;
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = soc.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = soc.Apellido;
                comando.Parameters.Add("Nac", MySqlDbType.Date).Value = soc.FechaNac;
                comando.Parameters.Add("Direc", MySqlDbType.VarChar).Value = soc.Direccion;
                comando.Parameters.Add("Telef", MySqlDbType.VarChar).Value = soc.Telefono;
                comando.Parameters.Add("Em", MySqlDbType.VarChar).Value = soc.Email;
                comando.Parameters.Add("Apt", MySqlDbType.Bit).Value = soc.AptoMedico;


                // Parámetro de salida
                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "rta";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);
                
                
                sqlCon.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(ParCodigo.Value);
            }
            catch (Exception ex)
            {
                salida = ex.Message;

            }
            // como proceso final
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { 
                    sqlCon.Close(); 
                } 
            }
            return salida;
        }
    }
}
