using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geben Sie eine Zahl ein: ");
            int iEingabeEins = Convert.ToInt16(Console.ReadLine());

            Console.Write("Geben Sie noch eine Zahl ein: ");
            int iEingabeZwei = Convert.ToInt16(Console.ReadLine());

            int iErgebnis = iEingabeEins + iEingabeZwei;
            Console.Write("Das Ergebnis der Addition: " + iErgebnis);

            Console.ReadKey();
        }
    }
}
