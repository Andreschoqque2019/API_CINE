using API_CINE.Dtos;
using API_CINE.Models;
using API_CINE.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_CINE.Controllers;

// CONTROLADOR  , EL QUE VA A RECIBIR LAS PETICIONES HTTP Y LLAMA AL SERVICIO

[ApiController]
[Route("api/tickets")]

// HEREDARA LOS METODOS DEL CONTROLBASE
public class TicketsController : ControllerBase
{
    private ITicketService _service; // SOLO SE ASIGNA EN EL CONSTRUCTOR  SIN

    // INYECCION DE DEPENDENCIAS , PARA PODER USAR NUESTRO SERVICIO SIN INSTANCIAR LA CLASE DE NUEVO
    public TicketsController(ITicketService service)
    {
        _service = service;
    }

    // GET: api/tickets → DEVUELVE TODOS (200)
    [HttpGet]
    public ActionResult<List<Ticket>> ObtenerTodos()
    {
        return Ok(_service.ObtenerTodos());
    }

    // GET: api/tickets/2 → DEVUELVE UNO POR SU ID (200)
    // EL {id} DE LA RUTA SE CONECTA CON EL PARAMETRO int id POR EL NOMBRE
    [HttpGet("{id}")]
    public ActionResult<Ticket> ObtenerPorId(int id)
    {
        return Ok(_service.ObtenerPorId(id));
    }

    // POST: api/tickets → CREA UN TICKET (201)
    // EL DTO VIENE EN EL BODY COMO JSON , [APICONTROLLER] LO VALIDA ANTES DE ENTRAR
    // SI ALGO ESTA MAL RESPONDE 400 SOLITO
    [HttpPost]
    public ActionResult<Ticket> Crear(TicketRequestDto dto)
    {
        Ticket creado = _service.Crear(dto);

        // 201 CREATED + LA RUTA DONDE SE PUEDE CONSULTAR EL TICKET NUEVO
        // NAMEOF PA QUE SI RENOMBRAMOS EL METODO EL COMPILADOR NOS AVISE
        return CreatedAtAction(nameof(ObtenerPorId), new { id = creado.Id }, creado);
    }

    // PUT: api/tickets/2 → ACTUALIZA UN TICKET (200)
    [HttpPut("{id}")]
    public ActionResult<Ticket> Actualizar(int id, TicketRequestDto dto)
    {
        return Ok(_service.Actualizar(id, dto));
    }

    // DELETE: api/tickets/2 → ELIMINA UN TICKET (204)
    // IACTIONRESULT SIN <TICKET> PORQUE NO DEVUELVE NADA
    [HttpDelete("{id}")]
    public IActionResult Eliminar(int id)
    {
        _service.Eliminar(id);

        // 204 NO CONTENT : SE ELIMINO Y NO HAY NADA QUE DEVOLVER
        return NoContent();
    }
}
