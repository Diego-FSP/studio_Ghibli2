namespace Peli;

public class PeliculaCE
{
    public int IdPelicula { get; set; }

    public required string Nombre { get; set; }

    public DateTime FechaEstreno { get; set; }

    public DateTime FechaCreacion { get; set; }

    public required string Duracion { get; set; }

    public required string Genero { get; set; }

    public required string Calificacion { get; set; }

    public int Presupuesto { get; set; }

    public required string ProgramaEstilo { get; set; }

    public int idStudio { get; set; }

    public required int director { get; set; }
}