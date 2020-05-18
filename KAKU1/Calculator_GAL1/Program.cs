using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_GAL1
{
    class Program_ADD
    {
        static double a, b;
        static void Main(string[] args)
        {
            Console.WriteLine("Posshitaem_2?");
            Console.WriteLine("Enter a: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            b = double.Parse(Console.ReadLine());

            ProgDELEN summ = new ProgDELEN();
            summ.DEVD(a, b);

            // ---- giTe

            ProgDELEN2.DEVD(a, b);

            Console.ReadKey();
        }
    }
    class ProgDELEN
    {
        public void DEVD(double a, double b)
        {
            var dvd = a / b;
            Console.WriteLine($"dvd: {dvd}");
        }
    }

    class ProgDELEN2
    {
        public static void DEVD(double a, double b)
        {
            var dvd = a / b;
            Console.WriteLine($"dvd: {dvd}");
        }
    }
}