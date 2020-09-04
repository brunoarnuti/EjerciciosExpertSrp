using System;
using System.Collections.Generic;

namespace SRP
{
    public class Estante
    {

        public string Nombre { get; set; }

        private List<Libro> Libros { get; set; }

        public Estante(String nombre)
        {
            this.Nombre = nombre;
            this.Libros = new List<Libro>();
        }

        public void AgregarLibro(Libro libro)
        {
            this.Libros.Add(libro);
        }

        public void QuitarLibro(Libro libro)
        {
            this.Libros.Remove(libro);
        }

       

    }
}
