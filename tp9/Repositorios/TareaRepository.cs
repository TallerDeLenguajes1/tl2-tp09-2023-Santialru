using System;
using System.Collections.Generic;
using System.Linq;
namespace tp9.repos;

public class TareaRepository : ITareaRepository
{
    private List<Tarea> tareas; // Debes inicializar y mantener esta lista en la clase.

    public TareaRepository()
    {
        // Inicializa la lista de tareas.
        tareas = new List<Tarea>();
    }

    public Tarea CrearTareaEnTablero(int idTablero, Tarea tarea)
    {
        tarea.Id = GenerarIdUnico(); // Asignar un nuevo ID único.
        tarea.IdTablero = idTablero;
        tareas.Add(tarea);
        return tarea;
    }

    public Tarea ModificarTarea(int id, Tarea tarea)
    {
        Tarea tareaExistente = tareas.FirstOrDefault(t => t.Id == id);
        if (tareaExistente != null)
        {
            tareaExistente.Nombre = tarea.Nombre;
            tareaExistente.Descripcion = tarea.Descripcion;
            tareaExistente.Color = tarea.Color;
            tareaExistente.Estado = tarea.Estado;
            // Modificar otros campos si es necesario.
        }
        return tareaExistente;
    }

    public Tarea ObtenerTareaPorId(int id)
    {
        return tareas.FirstOrDefault(t => t.Id == id);
    }

    public List<Tarea> ListarTareasAsignadasAUsuario(int idUsuario)
    {
        return tareas.Where(t => t.IdUsuarioAsignado == idUsuario).ToList();
    }

    public List<Tarea> ListarTareasDeTablero(int idTablero)
    {
        return tareas.Where(t => t.IdTablero == idTablero).ToList();
    }

    public void EliminarTarea(int idTarea)
    {
        Tarea tareaExistente = tareas.FirstOrDefault(t => t.Id == idTarea);
        if (tareaExistente != null)
        {
            tareas.Remove(tareaExistente);
        }
    }

    public void AsignarUsuarioATarea(int idUsuario, int idTarea)
    {
        Tarea tarea = tareas.FirstOrDefault(t => t.Id == idTarea);
        if (tarea != null)
        {
            tarea.IdUsuarioAsignado = idUsuario;
        }
    }

    private int GenerarIdUnico()
    {
        // Implementa lógica para generar un ID único, por ejemplo, basado en la fecha y hora actual.
        return DateTime.Now.Millisecond;
    }
}
