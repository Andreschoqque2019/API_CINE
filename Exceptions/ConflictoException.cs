namespace API_CINE.Exceptions;


// EXCEPCION PARA PODER CAPTURAR ERRORES Y DAR RESPUESTA PERZONALIZA
public class ConflictoException : Exception
{
    public ConflictoException(string mensaje) : base(mensaje) { }
}
