using API_CINE.Dtos;
using API_CINE.Models;

namespace API_CINE.Services;

// NUESTRO CONTRATO : CUALQUIER CLASE QUE IMPLEMENTE ESTA INTERFAZ DEBE TENER ESTOS METODOS
public interface ITicketService
{
    List<Ticket> ObtenerTodos();
    Ticket ObtenerPorId(int id);
    Ticket Crear(TicketRequestDto dto);
    Ticket Actualizar(int id, TicketRequestDto dto);
    void Eliminar(int id); // LE DEFINIMOS VOID PA QUE NO RETORNE NADA
}
