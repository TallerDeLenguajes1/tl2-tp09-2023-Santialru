using System.Collections.Generic;
using tp9.Models;
namespace tp9.repos;
public interface ITableroRepository
{
    Tablero CrearTablero(Tablero tablero);
    Tablero ModificarTablero(int id, Tablero tablero);
    Tablero ObtenerTableroPorId(int id);
    List<Tablero> ListarTableros();
    List<Tablero> ListarTablerosDeUsuario(int idUsuario);
    void EliminarTablero(int id);
}
