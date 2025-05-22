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
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = soc.NombreC;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = soc.ApellidoC;
                comando.Parameters.Add("Tip", MySqlDbType.VarChar).Value = soc.TDocC;
                comando.Parameters.Add("Doc", MySqlDbType.Int32).Value = soc.DocC;
                comando.Parameters.Add("Apt", MySqlDbType.VarChar).Value = soc.AptoMedico;
                comando.Parameters.Add("Nac", MySqlDbType.Date).Value = soc.FechaNac;

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
                } //;
            }
            return salida;
        }
    }
}
