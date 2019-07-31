using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Bankomat
    {
        int stanje = 1000;
        internal int trenutnoStanje { private set; get; }

        internal void Isplata(int isplati)
        {
            if (isplati < 0)
            {
                Console.WriteLine("Molimo Vas pokusajte ponovo\n");
                //return 0;
            }

            else {
                if (isplati > trenutnoStanje) {
                    Console.WriteLine("Nemate dovoljno novca na racunu za zeljenu isplatu. Pokusajte ponovo\n");
                }
                else stanje -= isplati; }
        }
        
        internal void Uplata (int uplati)
        {
            if (uplati < 0)
            {
                Console.WriteLine("Molimo Vas pokusajte ponovo");
            }

            else { stanje += uplati; }

        }

        internal int trenutno()
        {
            return this.trenutnoStanje=stanje;
        }

    }
}
