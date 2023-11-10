namespace tp9.Models;
public class Usuario
{
    private int id;
    private string nombreDeUsuario;

    public Usuario(int id, string nombreDeUsuario)
    {
        this.id = id;
        this.nombreDeUsuario = nombreDeUsuario;
    }

    public int Id { get => id; set => id = value; }
    public string NombreDeUsuario { get => nombreDeUsuario; set => nombreDeUsuario = value; }
}