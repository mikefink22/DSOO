using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaApp
{ 
    internal class Biblioteca
    {
        private List<Libro> libros;
        public Biblioteca()
        {
            this.libros = new List<Libro>();
        }

       
        public bool agregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro == null)
            { 
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }

        public void listarLibros()
        {
            Console.WriteLine("Lista de libros:");
            foreach (Libro libro in libros)
            {
                Console.WriteLine(libro.ToString());
            }
        }

        public void eliminarLibro(string titulo)
        {
            Libro libro = buscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                Console.WriteLine($"El libro '{titulo}' ha sido eliminado.");
            }
            else
            {
                Console.WriteLine($"El libro '{titulo}' no se encuentra en la biblioteca.");
            }
        }

        private Libro buscarLibro(string titulo)
        {
            Libro libroBuscado = null;
            int i = 0;
            while (i < libros.Count && !libros[i].getTitulo().Equals(titulo))
            {
                i++;
            }
            if (i < libros.Count)
            {
                libroBuscado = libros[i];
            }
            return libroBuscado;
        }





    }
}
