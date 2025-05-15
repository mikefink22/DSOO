using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Lector
    {
        private string nombre;
        private string dni;
        private List<Libro> librosPrestados;


        // metodo CONSTRUCTOR
        public Lector(string nombre, string dni)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.librosPrestados = new List<Libro>();
        }


        // metodo GET (utilizado desde el metodo buscarLector de la clase Biblioteca)
        public string getDni()
        {
            return dni;
        }

        // AGREGAR un nuevo libro a la colección de libros prestados del lector
        public void agregarLibroPrestado(Libro libro)
        {
            librosPrestados.Add(libro);
        }

        // OBTENER la cantidad de libros prestados del lector
        public int getCantidadPrestamos()
        {
            return librosPrestados.Count;
        }

        //metodo ToString (utilizado desde el metodo listarLibros de la clase Biblioteca)
        public override string ToString()
        {
            string resultado = "Nombre: " + nombre + "  Dni: " + dni;

            if (librosPrestados.Count > 0)
            {
                resultado += "\n    PRÉSTAMOS:";
                foreach (var libro in librosPrestados)
                {
                    resultado += "\n  --" + libro.ToString();
                }
            }
            else
            {
                resultado += "  SIN PRÉSTAMOS.";
            }

            return resultado;
        }

     


    }
}