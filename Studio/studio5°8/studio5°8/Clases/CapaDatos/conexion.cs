//using MySqlConnector;

//using MySqlConnector;
using MySql.Data.MySqlClient;
namespace studio5_8.Clases.CapaDatos;

class conexion
{
    MySqlConnection conex = new MySqlConnection();
    static string servidor = "Localhost";
    static string bd = "studio";
    static string usuario = "root";
    static string password = "root";
    static string puerto = "3306";

    string cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
    public MySqlConnection establecerConexion()
    {
        try
        {
            conex.ConnectionString = cadenaConexion;
            conex.Open();
            MessageBox.Show("Se logro a la base de Datos Correctamete");
        }
        catch (MySqlException e)
        {
            MessageBox.Show("No se pudo conectar la base de datos, error: " + e.ToString());
        }
        return conex;
    }
}