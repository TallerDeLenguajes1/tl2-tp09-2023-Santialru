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
    
    public void ModificarTablero(int id, Tablero tablero)
    {
        SQLiteConnection connection = new SQLiteConnection(cadenaConexion);
        SQLiteCommand command = connection.CreateCommand();
        command.CommandText =  $"UPDATE tablero SET id = '{tablero.Id1}', idUsuarioPropietario = '{tablero.IdUsuarioPropietario1}', nombre = '{tablero.Nombre1}', descripcion = '{tablero.Descripcion1}';";
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public Tablero ObtenerTableroPorId(int idTablero)
    {
        SQLiteConnection connection = new SQLiteConnection(cadenaConexion);
        var tablero = new Tablero();
        SQLiteCommand command = connection.CreateCommand();
        command.CommandText = $"SELECT * FROM tablero WHERE id = '{idTablero}';";
        command.CommandText = "SELECT * FROM tablero WHERE id = @idTablero";
        command.Parameters.Add(new SQLiteParameter("@idDirector", idTablero));
        connection.Open();
        using(SQLiteDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
                tablero.Id1 = Convert.ToInt32(reader["id"]);
                tablero.IdUsuarioPropietario1 = Convert.ToInt32(reader["idUsuarioPropietario"]);
                tablero.Nombre1 = reader["nombre"].ToString();
                tablero.Descripcion1 = reader["descripcion"].ToString();
            }
        }
        connection.Close();

        return (tablero);
    }
    
}
