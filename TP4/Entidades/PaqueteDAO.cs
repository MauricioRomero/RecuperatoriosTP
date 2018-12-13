using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Entidades
{
    class PaqueteDAO
    {
        #region Atributos
        private static SqlConnection _conexion;
        private static SqlCommand _comando;
        #endregion

        #region Constructores
         static PaqueteDAO()
        {
            //Creo un objeto sqlConnection
            PaqueteDAO._conexion = new SqlConnection(Properties.Settings.Default.correo_sp_2017ConnectionString);
            //Creo un Objeto sqlCommand
            PaqueteDAO._comando = new SqlCommand();
            //Indico el tipo de commando
            PaqueteDAO._comando.CommandType = System.Data.CommandType.Text;
            //Establezco la conexion
            PaqueteDAO._comando.Connection = PaqueteDAO._conexion;
        }
        #endregion

        #region Methods

        public static bool Insertar(Paquete p)
        {
            bool todoBien = false;
            try
            {
                string sql = "INSERT INTO Paquetes (direccionEntrega,trackingID) VALUES(";
                sql = sql + "'" + p.DireccionEntrega + "','" + p.TracingID;

                //Paso la instruccion sql
                PaqueteDAO._comando.CommandText = sql;

                //Abro la conexion a la base de datos
                PaqueteDAO._conexion.Open();

                //Ejecuto el command
                PaqueteDAO._comando.ExecuteNonQuery();

                todoBien = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                if (todoBien)
                {
                    PaqueteDAO._conexion.Close();
                }
            }
            return todoBien;
        }


        #endregion
    }
}
