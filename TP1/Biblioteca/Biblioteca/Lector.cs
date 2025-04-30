using System;
using System.Collections.Generic;
using System.Text;

    namespace BibliotecaApp
    {
        internal class Lector
        {
            public string Nombre { get; set; }
            public string Dni { get; set; }
            public List<Libro> LibrosPrestados { get; private set; }
            public int MaxPrestamosVigentes { get; private set; }

            public Lector(string nombre, string dni)
            {
                Nombre = nombre;
                Dni = dni;
                LibrosPrestados = new List<Libro>();
                MaxPrestamosVigentes = 3; // Máximo de 3 préstamos vigentes por lector
            }

            public bool PuedeTomarPrestamo()
            {
                return LibrosPrestados.Count < MaxPrestamosVigentes;
            }

            public void TomarPrestamo(Libro libro)
            {
                if (PuedeTomarPrestamo())
                {
                    LibrosPrestados.Add(libro);
                    Console.WriteLine($"{Nombre} ({Dni}) ha tomado prestado el libro: {libro.getTitulo()}");
                }
                else
                {
                    Console.WriteLine($"{Nombre} ({Dni}) ha alcanzado el límite de {MaxPrestamosVigentes} préstamos vigentes.");
                }
            }

            public void DevolverLibro(Libro libro)
            {
                if (LibrosPrestados.Contains(libro))
                {
                    LibrosPrestados.Remove(libro);
                    Console.WriteLine($"{Nombre} ({Dni}) ha devuelto el libro: {libro.getTitulo}");
                }
                else
                {
                    Console.WriteLine($"{Nombre} ({Dni}) no tenía prestado el libro: {libro.getTitulo}.");
                }
            }
        }
    }

