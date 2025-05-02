using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private string editorial;

        // metodo CONSTRUCTOR
        public Libro (string titulo, string autor, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }

        // metodo GET (utilizado desde el metodo buscarLibro de la clase Biblioteca)
        public string getTitulo()
        {
            return titulo;
        }

        //metodo ToString (utilizado desde el metodo listarLibros de la clase Biblioteca)
        public override string ToString()
        {
            return "Título: " + titulo + " Autor: " + autor + " Editorial: " + editorial;
        }

    }
}
