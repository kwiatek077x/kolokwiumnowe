using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Gosc
    {
        private string imie;
        private string nazwisko;

        private Gosc(string imie, string nazwisko)
        { 
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        private string PobierzImie()
        {
            return imie; 
            
        }
        private string PobierzNazwisko()
        { 
            return nazwisko;
        }
        
    }
}
