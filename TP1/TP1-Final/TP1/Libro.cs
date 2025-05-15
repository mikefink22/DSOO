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

        // método CONSTRUCTOR
        public Libro (string titulo, string autor, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }

        // método GET (utilizado desde el método buscarLibro de la clase Biblioteca)
        public string getTitulo()
        {
            return titulo;
        }

        //método ToString (utilizado desde el método listarLibros de la clase Biblioteca)
        public override string ToString()
        {
            return "Título: " + titulo + ";    Autor: " + autor + ";    Editorial: " + editorial;
        }

    }
}
