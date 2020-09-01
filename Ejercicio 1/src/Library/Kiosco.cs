using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda)
        {
            Double pesos = Conversor.ConvertirAPesos(dinero, moneda);
            //return pesos >= a.PrecioDulce + a.PrecioMasa; Lo ideal seria que la propia clase alfajor sume los precios, ya que es esa clase la que tiene la informacion idicada para hacerlo (Expert)
            return pesos >= a.GetPrecioTotal();
        }
     
    }
}