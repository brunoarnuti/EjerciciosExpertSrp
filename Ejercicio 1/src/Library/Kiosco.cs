using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda)
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;//Lo ideal seria que la propia clase alfajor sume los precios, ya que es esa clase la que tiene la informacion idicada para hacerlo (Expert)
        }
        private Double ConvertirAPesos(Double dinero, String moneda)//En mi opinion, seria mejor tener una clase que se encargue de las conversiones, ya que si quisieramos modificar algo de la forma en la que se hacen las conversiones hay que modificar la clase kiosco, cosa que no tiene mucho sentido. (SRP)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}