using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datum_convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // A bemeneti dátum string
            string datumString = "2023.12.23.";

            // A várt dátum formátuma
            string datumFormatum = "yyyy.MM.dd.";

            // Konvertálás DateTime típussá
            DateTime datum;
            if (DateTime.TryParseExact(datumString, datumFormatum, null, System.Globalization.DateTimeStyles.None, out datum))
            {
                Console.WriteLine("Konvertálás sikerült. Az eredmény: " + datum.Year);
            }
            else
            {
                Console.WriteLine("Hiba történt a konvertálás során.");
            }
            
        }
    }
}
