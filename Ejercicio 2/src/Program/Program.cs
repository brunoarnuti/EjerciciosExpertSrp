using System;

namespace SRP
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Design Patterns","Erich Gamma & Others","001-034");
            Libro libro2 = new Libro("Pro C#","Troelsen","001-035");
            Biblioteca bibliotecaCentral = new Biblioteca("biblioteca1");
            Sector sectorA = new Sector("sectorA");
            Estante estanteA = new Estante("estanteA");

            bibliotecaCentral.AlmacenarLibro(estanteA, sectorA, libro1);
          
        }
    }
}
