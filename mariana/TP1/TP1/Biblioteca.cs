using System;
using System.Collections.Generic;
using System.Linq; // no lo tiene la profe
using System.Text;
using System.Threading.Tasks; // no lo tiene la profe


namespace TP1
{
    internal class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectores;

        // metodo CONSTRUCTOR
        public Biblioteca()
        {
            this.libros = new List<Libro>();
            this.lectores = new List<Lector>();
        }
      

        // BUSCAR libro por su nombre
        private Libro buscarLibro(string titulo)
        {
            Libro libroBuscado = null;
            int i = 0;
            while (i < libros.Count && !libros[i].getTitulo().Equals(titulo))
                i++;
            if (i != libros.Count)
            {
                libroBuscado = libros[i];
            }
            return libroBuscado;
        }

        // BUSCAR lector por su dni
        private Lector buscarLector(string dni)
        {
            Lector lectorBuscado = null;
            int i = 0;
            while (i < lectores.Count && !lectores[i].getDni().Equals(dni))
                i++;
            if (i != lectores.Count)
            {
                lectorBuscado = lectores[i];
            }
            return lectorBuscado;
        }


        // AGREGAR nuevo libro a la coleccion de libros (solo si no está previamente registrado)
        public bool agregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro libro = buscarLibro(titulo);
            if (libro == null)
            {
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }

        // AGREGAR nuevo lector a la coleccion de lectores (solo si no está previamente registrado)
        public bool altaLector(string nombre, string dni)
        {
            bool resultado = false;
            Lector lector = buscarLector(dni);
            if (lector == null)
            {
                lector = new Lector(nombre, dni);
                lectores.Add(lector);
                resultado = true;
            }
            return resultado;
        }

        // MOSTRAR lista de libros
        public void listarLibros()
        {
            foreach (var libro in libros)
            { 
                Console.WriteLine(libro);  
            }
        }

        // MOSTRAR lista de lectores
        public void listarLectores()
        {
            foreach (var lector in lectores)
            {
                Console.WriteLine(lector);
            }
        }


        // ELIMINAR libro de la colección de libros
        public bool eliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro libro = buscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                resultado = true;
            }
            return resultado;
        }


        // OBTENER cantidad de préstamos del lector
        private int obtenerCantidadPrestamos(string dni)
        {
            Lector lector = buscarLector(dni);
            int cantidad = 0;
            if (lector != null)
            {
                cantidad = lector.getCantidadPrestamos();
            }
            return cantidad;
        }

        // PRESTAR un libro al lector
        public string prestarLibro(string titulo, string dni)
        {
            string resultado = "";
            Libro libro = buscarLibro(titulo);
            Lector lector = buscarLector(dni);

            if (libro != null && lector != null)
            {
                int cantidad = obtenerCantidadPrestamos(dni);
                if (cantidad < 3)
                {
                    libros.Remove(libro);
                    lector.agregarLibroPrestado(libro);
                    resultado = "PRESTAMO EXITOSO";
                }
                else
                {
                    resultado = "TOPE DE PRESTAMO ALCANZADO";
                }
            }
            else if (libro == null)
            {
                resultado = "LIBRO INEXISTENTE";
            }
            else if (lector == null)
            {
                resultado = "LECTOR INEXISTENTE";
            }
            return resultado;

        }
    }
}
