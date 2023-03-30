public abstract class VehiculoMonoplazaBase : IVehiculoMonoplaza
{
    private bool encendido;
    private bool detenido;
    private bool enMovimiento;

    public string Escuderia { get; }

    public VehiculoMonoplazaBase(string escuderia)
    {
        Escuderia = escuderia;
    }

    public void Encender()
    {
        if (!encendido)
        {
            encendido = true;
            Console.WriteLine($"{Escuderia} está encendido.");
        }
        else
        {
            Console.WriteLine($"{Escuderia} ya está encendido.");
        }
    }

    public void Apagar()
    {
        if (encendido && detenido)
        {
            encendido = false;
            Console.WriteLine($"{Escuderia} está apagado.");
        }
        else
        {
            Console.WriteLine($"{Escuderia} no se puede apagar en este momento.");
        }
    }

    public void Detener()
    {
        if (encendido && enMovimiento)
        {
            detenido = true;
            enMovimiento = false;
            Console.WriteLine($"{Escuderia} está detenido.");
        }
        else
        {
            Console.WriteLine($"{Escuderia} no se puede detener en este momento.");
        }
    }

    public void Mover()
    {
        if (encendido && detenido)
        {
            detenido = false;
            enMovimiento = true;
            Console.WriteLine($"{Escuderia} está en movimiento.");
        }
        else
        {
            Console.WriteLine($"{Escuderia} no se puede mover en este momento.");
        }
    }

    public abstract decimal MejorTiempoEnPrueba(int vueltas);
}
