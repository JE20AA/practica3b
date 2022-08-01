using System;
namespace practica3b;
public class ordenregular:ordenbase
{
    public override double CalculoTotal()
    {
        Console.WriteLine("Calculo del precio total de un pedido normal");
        return productos.Sum(x => x.precio );
    }
}