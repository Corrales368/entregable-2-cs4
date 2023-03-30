public class Ingrediente
{
    public string Nombre { get; }
    public int Cantidad { get; }
    public decimal Precio { get; }

    public Ingrediente(string nombre, int cantidad, decimal precio)
    {
        Nombre = nombre;
        Cantidad = cantidad;
        Precio = precio;
    }
}

public class Pastel : IPastel
{
    public string Nombre { get; set; }
    public string Tamaño { get; set; }
    public List<Ingrediente> Ingredientes { get; private set; } = new List<Ingrediente>();

    public decimal CalcularCosto()
    {
        decimal total = 0;
        foreach (Ingrediente ingrediente in Ingredientes)
        {
            total += ingrediente.Precio * ingrediente.Cantidad;
        }
        return total;
    }

    public string ListaIngredientes()
    {
        string lista = "";
        foreach (Ingrediente ingrediente in Ingredientes)
        {
            lista += $"{ingrediente.Nombre} x{ingrediente.Cantidad}\n";
        }
        return lista;
    }

    public int CantidadIngredientes()
    {
        return Ingredientes.Count;
    }

    public void AgregarIngrediente(Ingrediente ingrediente)
    {
        Ingredientes.Add(ingrediente);
    }
}


Pastel pastel = new Pastel();
pastel.Nombre = "Pastel de Chocolate";
pastel.Tamaño = "Grande";
pastel.AgregarIngrediente(new Ingrediente("Harina", 3, 2.5m));
pastel.AgregarIngrediente(new Ingrediente("Azúcar", 2, 1.8m));
pastel.AgregarIngrediente(new Ingrediente("Chocolate", 1, 5.5m));

Console.WriteLine($"El pastel {pastel.Nombre} de tamaño {pastel.Tamaño} tiene los siguientes ingredientes:\n{pastel.ListaIngredientes()}");
Console.WriteLine($"El pastel tiene un total de {pastel.CantidadIngredientes()} ingredientes y su costo es de {pastel.CalcularCosto()} dólares.");
