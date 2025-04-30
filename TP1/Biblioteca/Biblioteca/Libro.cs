using System;
using System.Collections.Generic;
using System.Text;

namespace Colecciones
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private string editorial;  

        public Libro(string titulo, string autor, string editorial) 
        { 
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }
        public string getTitulo()
        {
            return titulo;
        }

        // Sobreescritura del método ToString() para una representación legible del objeto
        public override string ToString()
        {
            return $"Título: {titulo}\n, Autor: {autor}\n, Editorial: {editorial}";
        }
    }
}
