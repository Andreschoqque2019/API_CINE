namespace API_CINE.Models;

public class Ticket
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public int PeliculaId { get; set; }
    public DateTime FechaFuncion { get; set; }
    public string Sala { get; set; } = "";
    public string Asiento { get; set; } = "";
    public decimal Precio { get; set; }
    public string Estado { get; set; } = "Activo";

    public Ticket() { }

    public Ticket(int id, int clienteId, int peliculaId, DateTime fechaFuncion,
                  string sala, string asiento, decimal precio)
    {
        Id = id;
        ClienteId = clienteId;
        PeliculaId = peliculaId;
        FechaFuncion = fechaFuncion;
        Sala = sala;
        Asiento = asiento;
        Precio = precio;
    }
}
