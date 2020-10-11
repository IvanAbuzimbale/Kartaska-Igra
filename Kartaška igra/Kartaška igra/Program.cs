using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartaška_igra
{
    class Program
    {
        static void Main(string[] args)
        {
            int karte, broj_bodova = 0;
            while (broj_bodova < 31){
                Console.Write("Odaberite broj karte: ");
                
                karte = Convert.ToInt32(Console.ReadLine());

                if  (karte > 13 || karte < 1)
                {
                    Console.WriteLine("Krivo ste unjeli, molimo da unesete ispravan unos.");
                    continue;
                }
                broj_bodova += karte;

                if (broj_bodova == 31)
                {
                    Console.WriteLine("Pobijedili ste!");
                }
                if (broj_bodova > 31){
                    Console.WriteLine("Izgubili ste!");
                }
            }
        }
    }
}
