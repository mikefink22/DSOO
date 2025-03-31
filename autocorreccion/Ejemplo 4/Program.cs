using System;

namespace Semana1_Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            // Pedir al usuario que ingrese un número entero de 4 dígitos
            Console.Write("Ingrese un número entero de 4 dígitos: ");
            numero = int.Parse(Console.ReadLine());

            // Verificar si el número tiene 4 dígitos
            if (numero >= 1000 && numero <= 9999)
            {
                // Calcular la suma de los dígitos
                int suma = 0;
                int temp = numero;

                while (temp > 0)
                {
                    int digito = temp % 10;
                    suma += digito;
                    temp /= 10;
                }

                // Mostrar los sumandos y el resultado
                Console.Write("Sumandos: ");
                int divisor = 1000;

                while (divisor >= 1)
                {
                    int digito = numero / divisor;
                    Console.Write(digito);

                    if (divisor > 1)
                        Console.Write(" + ");
                    numero %= divisor;
                    divisor /= 10;
                }
                Console.WriteLine(" = " + suma);
            }
            else
                Console.WriteLine("El número debe tener 4 dígitos. Inténtelo nuevamente.");
        }
    }
}