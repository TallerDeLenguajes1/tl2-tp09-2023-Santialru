namespace tp9.Models;
public class Tablero
{
private int Id;
private int IdUsuarioPropietario;
private string Nombre;
private string Descripcion;

    public Tablero(int id, int idUsuarioPropietario, string nombre, string descripcion)
    {
        Id = id;
        IdUsuarioPropietario = idUsuarioPropietario;
        Nombre = nombre;
        Descripcion = descripcion;
    }

    public int Id1 { get => Id; set => Id = value; }
    public int IdUsuarioPropietario1 { get => IdUsuarioPropietario; set => IdUsuarioPropietario = value; }
    public string Nombre1 { get => Nombre; set => Nombre = value; }
    public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
}