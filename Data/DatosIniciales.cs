using API_CINE.Models;

namespace API_CINE.Data;

// PERSISTENCIA LOCAL ( EN LISTAS )
public static class DatosIniciales
{
    // INICIALIZAMOS VARIOS EN LISTAS LOS OBJETOS DE LAS CLASES CLIENTES , PELICULAS Y TICKETS

    //STATIC PARA USARLO DESDE OTRAS PARTES SIN INSTANCIAR LA CLASE DE NUEVO
    public static List<Cliente> Clientes =
    [
        new Cliente(1, "Ana Torres", "72451234", "ana@correo.com"),
        new Cliente(2, "Luis Ramos", "70112233", "luis@correo.com"),
        new Cliente(3, "Sofía Paredes", "75998877", "sofia@correo.com")
    ];

    public static List<Pelicula> Peliculas =
    [
        new Pelicula(1, "Intensa-Mente 2", "Animación", 96, "APT"),
        new Pelicula(2, "Dune: Parte Dos", "Ciencia ficción", 166, "+14"),
        new Pelicula(3, "Alien: Romulus", "Terror", 119, "+18")
    ];

    public static List<Ticket> Tickets =
    [
        new Ticket(1, 1, 1, new DateTime(2026, 10, 10, 16, 0, 0), "Sala 1", "F7", 15.50m),
        new Ticket(2, 2, 2, new DateTime(2026, 10, 10, 19, 30, 0), "Sala 3", "C4", 22.00m),
        new Ticket(3, 3, 3, new DateTime(2026, 10, 11, 21, 0, 0), "Sala 2", "H10", 18.00m)
    ];
}
