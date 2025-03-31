using System;

namespace Semana1_Ej6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreSocio1;
            string nombreSocio2;
            string nombreSocio3;
            double capitalSocio1;
            double capitalSocio2;
            double capitalSocio3;
            double capitalTotalAportado;
            double porcentajeSocio1;
            double porcentajeSocio2;
            double porcentajeSocio3;

            Console.Write("Ingresa el nombre del primer socio: ");
            nombreSocio1 = Console.ReadLine();
            Console.Write("Ingresa el capital que aportó el primer socio: ");
            capitalSocio1 = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el nombre del segundo socio: ");
            nombreSocio2 = Console.ReadLine();
            Console.Write("Ingresa el capital que aportó el segundo socio: ");
            capitalSocio2 = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el nombre del tercer socio: ");
            nombreSocio3 = Console.ReadLine();
            Console.Write("Ingresa el capital que aportó el tercer socio: ");
            capitalSocio3 = double.Parse(Console.ReadLine());
            capitalTotalAportado = capitalSocio1 + capitalSocio2 + capitalSocio3;
            porcentajeSocio1 = capitalSocio1 * 100 / capitalTotalAportado;
            porcentajeSocio2 = capitalSocio2 * 100 / capitalTotalAportado;
            porcentajeSocio3 = capitalSocio3 * 100 / capitalTotalAportado;

            //las siguientes 3 lineas es para obtener un numero con 2 decimales
            porcentajeSocio1 = (Math.Truncate(porcentajeSocio1 * 100) / 100);
            porcentajeSocio2 = (Math.Truncate(porcentajeSocio2 * 100) / 100); 
            porcentajeSocio3 = (Math.Truncate(porcentajeSocio3 * 100) / 100);
            Console.WriteLine("El socio: " + nombreSocio1 + " aportó: $" + capitalSocio1 + " con un porcentaje del: " + porcentajeSocio1 + "%");
            Console.WriteLine("El socio: " + nombreSocio2 + " aportó: $" + capitalSocio2 + " con un porcentaje del: " + porcentajeSocio2 + "%");
            Console.WriteLine("El socio: " + nombreSocio3 + " aportó: $" + capitalSocio3 + " con un porcentaje del: " + porcentajeSocio3 + "%");
            Console.WriteLine("Capital total aportado:" + capitalTotalAportado);
        }
    }
}
