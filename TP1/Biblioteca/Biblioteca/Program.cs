// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Colecciones
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();
            cargarLibro(10);
            cargarLibro(2);
            biblioteca.listarLibros();
            biblioteca.eliminarLibro("Libro5");
            biblioteca.listarLibros();


            void cargarLibro(int cantidad)
            {
                bool pide;
                for (int i = 1; i <= cantidad; i++)
                {
                    pide = biblioteca.agregarLibro($"Libro {i}", $"Autor {i}", $"Editorial {i}");
                    if (pide)
                    {
                        Console.WriteLine($"Libro {i} agregado correctamente.");
                    }
                    else
                    {
                        Console.WriteLine($"Libro {i} Ya existe en la biblioteca.");
                    }
                }
            }

        }

    }
}