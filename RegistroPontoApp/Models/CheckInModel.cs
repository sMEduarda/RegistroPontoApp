namespace RegistroPontoApp.Models;

public class CheckInModel
{
    public DateTime DataHora { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    // Pode adicionar mais depois: Id, UsuarioId, Tipo (entrada/saída), etc.
}