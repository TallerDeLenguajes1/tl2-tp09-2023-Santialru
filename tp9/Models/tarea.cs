namespace tp9.Models;
public class Tarea
{
    public Tarea(int id, int idUsuarioPropietario, string nombre, string descripcion, string color, EstadoTarea estado)
    {
        Id = id;
        IdUsuarioPropietario = idUsuarioPropietario;
        Nombre = nombre;
        Descripcion = descripcion;
        Color = color;
        Estado = estado;
    }

    private int id;
    private string nombre;
    private string descripcion;
    private string color;
    private EstadoTarea estado;
    private int idUsuarioPropietario;

    public int Id { get => id; set => id = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public string Color { get => color; set => color = value; }
    public EstadoTarea Estado { get => estado; set => estado = value; }
    public int IdUsuarioPropietario { get => idUsuarioPropietario; set => idUsuarioPropietario = value; }
}

public enum EstadoTarea
{
    Ideas,
    ToDo,
    Doing,
    Review,
    Done
}