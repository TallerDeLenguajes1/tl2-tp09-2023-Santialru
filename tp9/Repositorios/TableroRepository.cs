using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SQLite;
using System.Threading.Tasks;
using tp9.Models;


namespace tp9.repos;

public class TableroRepository : ITableroRepository
{
    private string cadenaConexion = "Data Source=DB/kanban.db;Cache=Shared";

    public void CrearTablero(Tablero tablero)
    {
        var query = $"INSERT INTO tablero (id, idUsuarioPropietario, nombre, descripcion) VALUES (@id,@idUsuarioPropietario,@descripcion)";
        using(SQLiteConnection connection = new SQLiteConnection(cadenaConexion))
        {
            connection.Open();
            var command = new SQLiteCommand(query, connection);
            
            command.Parameters.Add(new SQLiteParameter("@id", tablero.Id1));
            command.Parameters.Add(new SQLiteParameter("@idUsuarioPropietario", tablero.IdUsuarioPropietario1));
            command.Parameters.Add(new SQLiteParameter("@nombre", tablero.Nombre1));
            command.Parameters.Add(new SQLiteParameter("@descripcion", tablero.Descripcion1));

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
    
    
    
}
