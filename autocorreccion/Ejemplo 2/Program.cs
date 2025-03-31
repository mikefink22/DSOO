using System;

namespace Semana1_Ej2
{
    class Program
    {
        const int NUMERO_JURADOS = 3; // Número de jurados

        static void Main(string[] args)
        {
            double puntajeTotal;
            string nombre;
            Console.WriteLine("Ingrese los datos de los participantes.");
            Console.WriteLine("Cuando desee finalizar, ingrese 'FIN' como el nombre del participante.\n");
            // Pedir al usuario el nombre del participante. Lo pasamos a mayusculas
            Console.Write("Ingrese el nombre del participante: ");
            nombre = Console.ReadLine().ToUpper();
            // Si se ingresa "FIN", salir del bucle y finalizar el programa
            while (nombre != "FIN")
            {
                // Pedir al usuario el puntaje de cada jurado
                puntajeTotal = 0;

                for (int i = 1; i <= NUMERO_JURADOS; i++)
                {
                    Console.Write("Ingrese el puntaje del jurado " + i + " para " + nombre + ": ");
                    puntajeTotal += double.Parse(Console.ReadLine());
                }
                // Mostrar el puntaje total del participante
                Console.WriteLine("Puntaje total de " + nombre + ": " + puntajeTotal);
                // Pedir al usuario el nombre del proximo participante
                Console.Write("Ingrese el nombre del participante: ");
                nombre = Console.ReadLine().ToUpper();
            }
        }
    }
}
