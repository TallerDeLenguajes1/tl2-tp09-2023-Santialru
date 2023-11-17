using Microsoft.AspNetCore.Mvc;
using tp9.Models;
using tp9.repos;

namespace tp9.controllers;

[ApiController]
[Route("[controller]")]
public class TableroController : ControllerBase
{
    private TableroRepository manejoDeTableros; // Utilizo la clase o la interfaz?
    private readonly ILogger<TableroController> _logger;

    public TableroController(ILogger<TableroController> logger)
    {
        _logger = logger;
        manejoDeTableros = new();
    }

    [HttpPost("api/Tablero")] //Que devuelvo???
    public ActionResult<Tablero> AgregarTablero(Tablero t)
    {
        manejoDeTableros.CrearTablero(t);
        return Ok(t);
    }
    [HttpGet]
    [Route("api/tableros")]
    public ActionResult<List<Tablero>> GetListadoTablero()
    {
        var listaTableros = manejoDeTableros.ListarTableros();
        return Ok(listaTableros);
    }
}