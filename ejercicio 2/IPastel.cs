public interface IPastel
{
    string Nombre { get; set; }
    string Tamaño { get; set; }
    List<Ingrediente> Ingredientes { get; }
    decimal CalcularCosto();
    string ListaIngredientes();
    int CantidadIngredientes();
    void AgregarIngrediente(Ingrediente ingrediente);
}
