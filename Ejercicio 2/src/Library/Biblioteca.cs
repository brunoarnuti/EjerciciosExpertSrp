using System;
using System.Collections.Generic;

namespace SRP
{
    public class Biblioteca    {

        public string Nombre { get; set; }

        private List<Sector> Sectores { get; set; }

        public Biblioteca(String nombre)
        {
            this.Nombre = nombre;
            this.Sectores = new List<Sector>();
        }

        public void AgregarSector(Sector sector)
        {
            this.Sectores.Add(sector);
        }

        public void QuitarSector(Sector sector)
        {
            this.Sectores.Remove(sector);
        }

        public void AlmacenarLibro(Estante estante, Sector sector, Libro libro)
        {
            if (Sectores.Contains(sector))
            {
                if (sector.VerificarEstante(estante))
                {
                    estante.AgregarLibro(libro);
                }
                else
                {
                    sector.AgregarEstante(estante);
                    estante.AgregarLibro(libro);
                }
            }
            else
            {
                this.AgregarSector(sector);
                
                if (sector.VerificarEstante(estante))
                {
                    estante.AgregarLibro(libro);
                }
                else
                {
                    sector.AgregarEstante(estante);
                    estante.AgregarLibro(libro);
                }
            }

        }


        public void RetirarLibro(Estante estante, Sector sector, Libro libro)
        {
            if (Sectores.Contains(sector))
            {
                if (sector.VerificarEstante(estante))
                {
                    estante.QuitarLibro(libro);
                }
        
            }
        }

    }
}
