using System;

namespace TP1 
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            // LIBROS
            Console.WriteLine("\n--- REGISTRO DE LIBROS: ---");
            cargarLibros(10);
            cargarLibros(2); // intento de agregar repetidos
            Console.WriteLine("\n--- LISTA DE LIBROS: ---");
            biblioteca.listarLibros();
            Console.WriteLine("\n--- LISTA DE LIBROS, luego de eliminar: ---");
            biblioteca.eliminarLibro("Libro5");
            biblioteca.listarLibros();

            // LECTORES
            Console.WriteLine("\n--- REGISTRO DE LECTORES: ---");
            cargarLectores(3);
            cargarLectores(1); // intento de agregar repetidos
            Console.WriteLine("\n--- LISTA DE LECTORES: ---");
            biblioteca.listarLectores();

            // PRESTAMOS
            Console.WriteLine("\n--- PRÉSTAMOS: ---");
            Console.WriteLine(biblioteca.prestarLibro("Libro1", "Dni1")); // exitoso
            Console.WriteLine(biblioteca.prestarLibro("Libro2", "Dni1")); // exitoso
            Console.WriteLine(biblioteca.prestarLibro("Libro3", "Dni1")); // exitoso
            Console.WriteLine(biblioteca.prestarLibro("Libro4", "Dni1")); // tope alcanzado
            Console.WriteLine(biblioteca.prestarLibro("Libro9", "Dni10")); // lector inexistente
            Console.WriteLine(biblioteca.prestarLibro("Libro20", "Dni2")); // libro inexistente

            Console.WriteLine("\n--- LISTA DE LECTORES, luego de los préstamos: ---");
            biblioteca.listarLectores();
            Console.WriteLine("\n--- LISTA DE LIBROS, luego de los préstamos: ---");
            biblioteca.listarLibros();


            // metodos para cargar libros
            void cargarLibros(int cantidad)
            {
                bool pude = false;
                for (int i = 1; i <= cantidad; i++)
                {
                    pude = biblioteca.agregarLibro("Libro" + i, "Autor" + i, "Editorial" + i);
                    if (pude)
                    {
                        Console.WriteLine("Libro" + i + " agregado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Libro" + i + " ya existe en la biblioteca.");
                    }
                }
            }


            // metodos para cargar lectores
            void cargarLectores(int cantidad)
            {
                bool pude = false;
                for (int i = 1; i <= cantidad; i++)
                {
                    pude = biblioteca.altaLector("Lector" + i, "Dni" + i);
                    if (pude)
                    {
                        Console.WriteLine("Lector" + i + " agregado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine("Lector" + i + " ya existe en la biblioteca.");
                    }
                }
            }
        }
    }
}