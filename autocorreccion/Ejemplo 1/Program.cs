using System;

namespace Semana1_Ej1
{
    class Program
    {
        const double INCRENENTO_GANANCIA = 0.15; // Constante que representa el incremento del 15%

        static void Main(string[] args)
        {
            // Pedir al usuario que ingrese el precio del producto
            Console.Write("Ingrese el precio del producto: ");
            double precioProducto = double.Parse(Console.ReadLine());

            // Calcular el precio de venta (incluyendo el incremento del 15%)
            double precioVenta = precioProducto * (1 + INCRENENTO_GANANCIA);

            // Mostrar el resultado
            Console.WriteLine("El precio de venta es: " + precioVenta);
        }
    }
}
