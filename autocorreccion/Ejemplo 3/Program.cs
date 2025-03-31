using System;
using System.ComponentModel.Design;

namespace Semana1_Ej3
{
    class Program
    {
        const int NUMERO_JURADOS = 3; // Número de jurados
        const double PUNTAJE_MINIMO_ULTIMA_ETAPA = 80; // Puntaje mínimo para llegar a la última etapa

        static void Main(string[] args)
        {
            double puntajeTotal;
            bool llegaUltimaEtapa;
            string nombre;

            Console.WriteLine("Ingrese los datos de los participantes.");
            Console.WriteLine("Cuando desee finalizar, ingrese 'FIN' como el nombre del participante.\n");
            // Pedir al usuario el nombre del participante
            Console.Write("Ingrese el nombre del participante: ");
            nombre = Console.ReadLine().ToUpper();
            // Si se ingresa "FIN", salir del bucle y finalizar el programa
            while (nombre.ToUpper() != "FIN")
            {
                // Pedir al usuario el puntaje de cada jurado
                puntajeTotal = 0;
                for (int i = 1; i <= NUMERO_JURADOS; i++)
                {
                    Console.Write("Ingrese el puntaje del jurado " + i + " para " + nombre + ": ");
                    puntajeTotal += double.Parse(Console.ReadLine());
                }
                // Verificar si el participante llega a la última etapa (puntaje > 80)
                llegaUltimaEtapa = puntajeTotal > PUNTAJE_MINIMO_ULTIMA_ETAPA;
                // Mostrar el puntaje total y si el estudiante llega a la instancia final
                Console.WriteLine("Puntaje total de " + nombre + ": " + puntajeTotal);
                if (puntajeTotal > PUNTAJE_MINIMO_ULTIMA_ETAPA)
                    Console.WriteLine("Llega a la instancia final: Sí");
                else
                    Console.WriteLine("Llega a la instancia final: No");
                Console.WriteLine();
                // Pedir al usuario el nombre del participante
                Console.Write("Ingrese el nombre del proximo participante: ");
                nombre = Console.ReadLine().ToUpper();
            }
        }
    }
}
