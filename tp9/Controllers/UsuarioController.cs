using Microsoft.AspNetCore.Mvc;
using tp9.Models;
using tp9.repos;

namespace tp9.controllers;

[ApiController]
[Route("[controller]")]
public class UsuarioController : ControllerBase
{
    private UsuarioRepository manejoDeUsuarios; // Utilizo la clase o la interfaz?
    private readonly ILogger<UsuarioController> _logger;

    public UsuarioController(ILogger<UsuarioController> logger)
    {
        _logger = logger;
        manejoDeUsuarios = new();
    }

    [HttpPost("api/usuario")] //Que devuelvo???
    public ActionResult<Usuario> AgregarUsuario(Usuario u)
    {
        manejoDeUsuarios.CrearUsuario(u);
        return Ok(u);
    }
    [HttpGet]
    [Route("api/usuario")]
    public ActionResult<List<Usuario>> GetListadoUsuario()
    {
        var listaUsuarios = manejoDeUsuarios.ListarUsuarios();
        return Ok(listaUsuarios);
    }
    [HttpGet]
    [Route("api/usuario/{Id}")]
    public ActionResult<Usuario> GetUsuarioPorId(int Id)
    {
        var usuarioBuscado = manejoDeUsuarios.ObtenerUsuarioPorId(Id);
        return Ok(usuarioBuscado);
    }
    [HttpPut("api/tarea/{Id}/Nombre")] //Que devuelvo???
    public ActionResult<Usuario> ActualizarTarea(int Id, Usuario usuarioActualizado)
    {
        manejoDeUsuarios.ModificarUsuario(Id, usuarioActualizado);
        return Ok(usuarioActualizado);
    }
}