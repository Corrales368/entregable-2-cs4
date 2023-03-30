public interface ICircuitoMonoplaza
{
    string Nombre { get; }
    int VueltasPermitidas { get; }
    IVehiculoMonoplaza MonoplazaEnCircuito { get; }
    void AgregarMonoplaza(IVehiculoMonoplaza monoplaza);
    void SacarMonoplaza();
    void RealizarPrueba();
}
