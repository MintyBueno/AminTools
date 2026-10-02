using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace AminTools
{
    internal class HilfeMathe
    {
        public static double Addiere(double a, double b)
        {
            return a + b;
        }
        public static double Subtrahiere(double a, double b)
        {
            return a - b;
        }
        public static double Multipliziere(double a, double b)
        {
            return a * b;
        }
        public static double Dividiere(double a, double b)
        {
            return a / b;
        }
        public static double Potenz(double a, double b)
        {
            return Math.Pow(a, b);
        }
        public static bool IstGerade(int zahl)
        {
            return zahl % 2 == 0;
        }

        public static bool IstPrimzahl(int zahl)
        {
            if (zahl <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(zahl); i++)
            {
                if (zahl % i == 0) return false;
            }
            return true;
        }

        public static double Durchschnitt(params double[] zahlen)
        {
            if (zahlen.Length == 0) return 0;
            double summe = 0;
            foreach (var zahl in zahlen)
            {
                summe += zahl;
            }
            return summe / zahlen.Length;
        }
    }
}
