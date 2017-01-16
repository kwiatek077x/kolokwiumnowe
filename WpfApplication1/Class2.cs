using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
   abstract class Pokoj 
    {
        private int nrPokoju;
        private double cenaZaDzien;
       /* public int CompareTo(object value)
        {
            if (object = null) return 1;
        }*/
   

       abstract public string jakiPokoj();
       public int PobierzNrPokoju()

        {
            return nrPokoju;
        }
        
        public double PobierzCenaZaDzien()
        {
            return cenaZaDzien;
        }
       public Pokoj(int nrPokoju, double cenaZaDzien)
       {
           this.cenaZaDzien = cenaZaDzien;
           this.nrPokoju = nrPokoju;
       }



     
    }
}
