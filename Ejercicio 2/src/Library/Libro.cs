using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; }
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)//No me parece que la clase libro sepa acerca la organizacion de la biblioteca, supongase que se quiera usar esta clase libro para modelar libros electronicos, ya no tendria sentido este metodo
                                                                 //por eso me parece correcto la creacion de otra clase llamada biblioteca
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
