using System;
namespace practica3b;
    public class decorador: ordenbase
    {
        protected ordenbase orden;
        public decorador (ordenbase orden)
        {
            this.orden=orden;
        }
        public override double CalculoTotal()
        {
            Console.WriteLine("Calculo del precio total desde la clase decoradora");
            return orden.CalculoTotal();
        }
    }
