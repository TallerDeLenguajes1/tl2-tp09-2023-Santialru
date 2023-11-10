using System;
using System.Collections.Generic;
using System.Linq;
namespace tp9.repos;

public class UsuarioRepository : IUsuarioRepository
{
    private List<Usuario> usuarios; // Debes inicializar y mantener esta lista en la clase.

    public UsuarioRepository()
    {
        // Inicializa la lista de usuarios.
        usuarios = new List<Usuario>();
    }

    public Usuario CrearUsuario(Usuario usuario)
    {
        usuario.Id = GenerarIdUnico(); // Asignar un nuevo ID único.
        usuarios.Add(usuario);
        return usuario;
    }

    public Usuario ModificarUsuario(int id, Usuario usuario)
    {
        Usuario usuarioExistente = usuarios.FirstOrDefault(u => u.Id == id);
        if (usuarioExistente != null)
        {
            usuarioExistente.NombreDeUsuario = usuario.NombreDeUsuario;
            // Modificar otros campos si es necesario.
        }
        return usuarioExistente;
    }

    public List<Usuario> ListarUsuarios()
    {
        return usuarios;
    }

    public Usuario ObtenerUsuarioPorId(int id)
    {
        return usuarios.FirstOrDefault(u => u.Id == id);
    }

    public void EliminarUsuario(int id)
    {
        Usuario usuarioExistente = usuarios.FirstOrDefault(u => u.Id == id);
        if (usuarioExistente != null)
        {
            usuarios.Remove(usuarioExistente);
        }
    }

    private int GenerarIdUnico()
    {
        // Implementa lógica para generar un ID único, por ejemplo, basado en la fecha y hora actual.
        return DateTime.Now.Millisecond;
    }
}
