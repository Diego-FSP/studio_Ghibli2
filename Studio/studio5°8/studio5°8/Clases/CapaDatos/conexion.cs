//using MySqlConnector;

//using MySqlConnector;
using MySql.Data.MySqlClient;
using System.Drawing;
namespace studio5_8.Clases.CapaDatos;

public class Conexion
{
    public MySqlConnection conex = new MySqlConnection();
    static string servidor = "Localhost";
    static string bd = "studio";
    static string usuario = "root";
    static string password = "root";
    static string puerto = "3306";
    public Conexion(string u, string c)
    {
        usuario = u; 
        password = c;
        cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

    }
    public Conexion()
    {
        cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
    }
    string cadenaConexion;// "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";
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