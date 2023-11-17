using Microsoft.AspNetCore.Mvc;
using tp9.Models;
using tp9.repos;

namespace tp9.controllers;

[ApiController]
[Route("[controller]")]
public class TareaController : ControllerBase
{
    private TareaRepository manejoDeTareas; // Utilizo la clase o la interfaz?
    private readonly ILogger<TareaController> _logger;

    public TareaController(ILogger<TareaController> logger)
    {
        _logger = logger;
        manejoDeTareas = new();
    }

    [HttpPost("api/tarea")] //Que devuelvo??? Le cambio el nombre a la ruta?
    public ActionResult<Tarea> AgregarUsuario(int idTablero, Tarea t)
    {
        manejoDeTareas.CrearTarea(idTablero, t);
        return Ok(t);
    }

    [HttpPut("api/Tarea/{id}/Nombre/{Nombre}")] //Que devuelvo??? Esta bien hecho??
    public ActionResult<int> ActualizarTareaPorNombre(int id, string Nombre)
    {
        manejoDeTareas.ActualizarTareaPorNombre(id, Nombre);
        return Ok(id);
    }

    [HttpPut("api/Tarea/{id}/Estado/{estado}")] //Que devuelvo??? Esta bien hecho??
    public ActionResult<int> ActualizarTareaPorEstado(int id, int estado)
    {
        manejoDeTareas.ActualizarTareaPorEstado(id, estado);
        return Ok(id);
    }

    [HttpDelete("api/Tarea/{id}")] // Que devuelvo??
    public ActionResult<int> EliminarTareaPorId(int id)
    {
        manejoDeTareas.EliminarTarea(id);
        return Ok(id);
    }

    [HttpGet]
    [Route("api/Tarea/{Estado}")] // bien hecho??
    public ActionResult<int> GetCantidadPorEstado(int Estado)
    {
        var cantidad = manejoDeTareas.GetCantidadTareasPorEstado(Estado);
        return cantidad;
    }

    [HttpGet]
    [Route("api/Tarea/Usuario/{Id}")]
    public ActionResult<List<Tarea>> ListarTareasDeUsuario(int Id)
    {
        var listaTareas = manejoDeTareas.ListarTareasDeUsuario(Id);
        return Ok(listaTareas);
    }

    [HttpGet]
    [Route("api/Tarea/Tablero/{Id}")]
    public ActionResult<List<Tarea>> ListarTareasDeTablero(int Id)
    {
        var listaTareas = manejoDeTareas.ListarTareasDeTablero(Id);
        return Ok(listaTareas);
    }
}