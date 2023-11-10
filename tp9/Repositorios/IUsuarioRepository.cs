
using System.Collections.Generic;
namespace tp9.repos;
public interface IUsuarioRepository
{
    Usuario CrearUsuario(Usuario usuario);
    Usuario ModificarUsuario(int id, Usuario usuario);
    List<Usuario> ListarUsuarios();
    Usuario ObtenerUsuarioPorId(int id);
    void EliminarUsuario(int id);
}
