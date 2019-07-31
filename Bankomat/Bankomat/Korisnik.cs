using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Korisnik
    {
        internal string PinKod { set; get; }
       internal Korisnik(string Pin) {
            this.PinKod = Pin; 
        }

    }
}
