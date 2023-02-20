using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace DPRN3_U2_A1_MAZM
{
    class clsAltaVehiculo
    {

        protected internal DataTable Tabla;
        protected MySqlCommand comando;
        protected MySqlDataAdapter buscar;

        
        public  DataTable consultarVehiculo()
        {
            Tabla = new DataTable();


            //Ingresar informacion a base de datos
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.ConnectionString = "server = localhost; user = root; password = Cu213lona1973; database = base_automovil; port=3306";
            MySqlConnection conn = new MySqlConnection(builder.ConnectionString);
          
        try
            {
               String consulta = "SELECT idAutomovil, tipoVehiculo, fechaAdquision, marca, modelo, anio, imagenVehiculo, serie, color, verificacion FROM automovil";
                buscar = new MySqlDataAdapter(consulta, conn.ConnectionString);
                buscar.Fill(Tabla);

            }catch(Exception e)
            {
                Console.WriteLine(e);
            }

            return Tabla;
        }

        
        //Metodo insertar en base de datos
        public Boolean insertarDatosVehiculo(String tipoVehiculo, DateTime fecha, String marca, String modelo, String anio,  PictureBox fotoVehiculo, String serie, String color, String verificacion)
        {

            try
            {
                //String cadena = "INSERT INTO test SET tipoVehiculo='" + tipoVehiculo + "', marca='" + marca + "', imagenVehiculo=@imagen, verificacion='" + verificacion + "', fecha='" + fecha.ToString("yyy-MM-dd HH:mm:ss") + "'";
                String cadena = "INSERT INTO automovil SET tipoVehiculo='"+tipoVehiculo+"' ,fechaAdquision='" + fecha.ToString("yyyy-MM-dd HH:mm:ss")+"' , marca='" + marca + "', modelo='" + modelo + "', anio='" + anio + "', imagenVehiculo=@imagen, serie='" + serie + "', color='" + color + "', verificacion='" + verificacion+"'";


                byte[] imagenVehiculo = ClaseImagen.ImagenAByte(fotoVehiculo.Image);
                comando = new MySqlCommand(cadena, clsConexion.conexion);
                comando.Parameters.AddWithValue("@imagen", imagenVehiculo);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
                      
            comando.Parameters.AddWithValue("@imagen", fotoVehiculo);

            return true;
        }
    }
}
