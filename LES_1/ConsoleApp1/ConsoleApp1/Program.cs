using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program_Differ_Ops
    {
        public static int c;
        public static void Add(int a, int b)
        {
            c = a + b;   
        }
        public static double Sb(int a, int b)
        {
            double c = a - b; 
            return c;
        } 
        public static int Ml(int a, int b)
        {
            return a * b;
        }
        public static int Dv(int a, int b)
        {
            return a / b;
        }
        public static double Procent(double a, double procent)
        {
            return (a * procent)/100;
        }

        static void Main(string[] args)
        {
            Add(1, 5);
            double cSb = Sb(4, 2);
            int cMl = Ml(2,1);
            int cDv = Dv(10, 1);
            double cPr = Procent(100, 2);
            Console.WriteLine("Hi Auto TEST");
            Console.WriteLine(cSb);
            Console.WriteLine(cMl);
            Console.WriteLine(cDv);
            Console.WriteLine(cPr);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
 }