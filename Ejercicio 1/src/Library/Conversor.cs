using System;

namespace Expert_SRP
{
    public class Conversor 
    {
        private double monedaAConvertir;
        
        public Conversor(double monedaAConvertir = 0)
        {
            this.monedaAConvertir = monedaAConvertir;
        }
        public Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / monedaAConvertir;
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