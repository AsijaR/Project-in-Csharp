using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    class Program
    {
        static void Main(string[] args)
        {
            Korisnik k = new Korisnik("8987");
            Bankomat p = new Bankomat();
            do
            {
                Console.WriteLine("Unesite pin kod\n");
                if (!(int.TryParse(Console.ReadLine(), out int pin))) //KAD NAM NESTO NETREBA STAVLJAMO _
                    break;
                if (k.PinKod.Equals(pin.ToString()))
                {
                    do
                    {
                        Meni();
                        if (!(int.TryParse(Console.ReadLine(), out int izbor))) 
                            break;
                        switch (izbor)
                        {
                            case 1:
                                Console.WriteLine("Koliko zelite da uplatite?\n");
                                if (!(int.TryParse(Console.ReadLine(), out int uplati))) 
                                    break;
                                p.Uplata(uplati);
                                break;
                            case 2:
                                Console.WriteLine("Koliko zelite da isplatite?\n");
                                if (!(int.TryParse(Console.ReadLine(), out int isplati))) 
                                    break;
                                p.Isplata(isplati);
                                break;
                            case 3:
                                Console.WriteLine(p.trenutno());
                                break;
                            case 'q':
                                break;
                        }
                    } while (true);
                }
                else
                {
                    Console.WriteLine("Pin kod nije tacan, pokusajte ponovo");
                    
                }
            } while (true);
        }
            public static void Meni()
        {
            Console.WriteLine("1. Uplati novac");
            Console.WriteLine("2. Isplati novac");
            Console.WriteLine("3. Trenutno stanje");
            Console.WriteLine("q - izlaz");
        }
    }
}
