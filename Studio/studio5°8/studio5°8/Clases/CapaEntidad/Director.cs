namespace Directores;

public class Director
{
    public int idDirector { get; set; }
    public required string Nombre { get; set; }
    public required string Apellido { get; set; }
    public required string nacionalidad { get; set; }
    public DateTime FechaNacimiento { get; set; }
}