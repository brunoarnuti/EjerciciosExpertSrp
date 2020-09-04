using System;

namespace SRP
{
    public class Libro
    {

        public string Titulo { get ; }
        public string Autor { get ; }
        public string Codigo { get ;  }
        public string SectorBiblioteca { get ; set; } //En el caso de que en un futuro se quiera modelar un libro electronico con esta misma clase, no tiene mucho sentido que una instancia de libro electronico tenga atributos tales como sectores de biblioteca
        public string EstanteBiblioteca { get ; set; }

        public Libro(String titulo, String autor, String codigo)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.Codigo = codigo;
        }

        public void AlmacenarLibro(String sector, String estante)//No me parece que la clase libro sepa acerca la organizacion de la biblioteca, supongase que se quiera usar esta clase libro para modelar libros electronicos, ya no tendria sentido este metodo
                                                                 //por eso me parece correcto la creacion de otra clase llamada biblioteca
                                                                 //Si bien tengo en cuenta lo que dije anteriormente, no se me ocurre una forma facil de extraer este metodo y re-estructurar las clases sin usar herencia
        {
            this.SectorBiblioteca = sector;
            this.EstanteBiblioteca = estante;
        }

    }
}
