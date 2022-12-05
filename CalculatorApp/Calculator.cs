using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Calculator
    {
        static public int Penjumlahan(int a,int b)
        {
            return a + b;
        }
        static public int Pengurangan(int a,int b)
        {
            return a - b;
        }
        static public int Perkalian(int a,int b)
        {
            return a * b;
        }
        static public float Pembagian(int a,int b)
        {
            return (float)a / (float)b;
        }

    }
}
