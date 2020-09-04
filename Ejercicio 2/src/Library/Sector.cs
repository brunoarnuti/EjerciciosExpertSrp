using System;
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {

        public string Nombre { get; }

        private List<Estante> Estantes { get; set; }

        public Sector(String nombre)
        {
            this.Nombre = nombre;
            this.Estantes = new List<Estante>();
        }

        public void AgregarEstante(Estante estante)
        {
            this.Estantes.Add(estante);
        }

        public void QuitarEstante(Estante estante)
        {
            this.Estantes.Remove(estante);
        }

         public bool VerificarEstante(Estante estante)
        {
            if (Estantes.Contains(estante))
            {
                return true;   
            }
            else
            {
                return false;
            }

        }
         

    }
}
