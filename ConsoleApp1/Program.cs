using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cari nomor loker berapa ?");
            string nomorLoker = Console.ReadLine();
            Console.WriteLine(nomorLoker);

            int[] formulaKapasitas = { 5, 6, 7 };

            int _noLoker = Int32.Parse(nomorLoker);

            int lantai = 0;

            for (int j = 0; j < formulaKapasitas.Length && _noLoker > 0; j++)
            {
                if (_noLoker > 0)
                {
                    int kapasitasindex = formulaKapasitas[j];
                    _noLoker = _noLoker - kapasitasindex;

                    lantai = lantai + 1;

                    
                    if (_noLoker > 0)
                    {
                        if (j == formulaKapasitas.Length - 1)
                            j = -1;
                        else
                            continue;
                        
                    }
                    else
                        break;
                }
            }

            Console.WriteLine("Loker nomor "+ nomorLoker + " ada di lantai " + lantai);

        }

    }
}
