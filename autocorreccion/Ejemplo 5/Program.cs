using System;

namespace Semana1_Ej5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            // Pedir al usuario que ingrese un número entero
            Console.Write("Ingrese un número entero: ");
            numero = int.Parse(Console.ReadLine());

            // Calcular la suma de los dígitos
            int suma = 0;
            int temp = Math.Abs(numero); // Tomamos el valor absoluto para asegurarnos de trabajar con un número no negativo

            // Calcular el número de dígitos del número
            int digitos = 0;
            while (temp > 0)
            {
                temp /= 10;
                digitos++;
            }

            // Calcular el divisor
            int divisor = 1;
            for (int i = 1; i < digitos; i++)
                divisor *= 10;

            // Volver a asignar el valor absoluto del número para trabajar con números no negativos
            temp = Math.Abs(numero);

            // Calcular la suma y mostrar los sumandos
            Console.Write("Sumandos: ");
            for (int i = 0; i < digitos; i++)
            {
                int digito = temp / divisor;
                Console.Write(digito);

                suma += digito;
                temp %= divisor;
                divisor /= 10;

                if (divisor >= 1)
                    Console.Write(" + ");
            }
            Console.WriteLine(" = " + suma);
        }
    }
}
