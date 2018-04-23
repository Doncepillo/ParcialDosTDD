using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraBasica
{
    public class Calculadora
    {
        public int Sumar(int v1, int v2)
        {
            return v1 + v2;
        }

        public int SumarCaracteres(string v1, string v2)
        { 
            return Convert.ToInt16(v1) + Convert.ToInt16( v2);
        }

        public int SumarCaracteresB(string v1, string v2)
        {
            if (v1.Equals(""))
                {
                v1 = "0";
                }
            else
                {
                Convert.ToInt16(v1);
                }
            if (v2.Equals(""))
            {
                v2 = "0";
            }
            else
            {
                Convert.ToInt16(v2);
            }
            return Convert.ToInt16(v1 + v2);
        }

        public int Restar(int v1, int v2)
        {
            return v1 - v2;
        }

        public int Multiplicar(int v1, int v2)
        {
            return v1 * v2;
        }

        public int MultiplicarB(string v1, int v2)
        {
            return (v1.Equals("")) ? 0 * v2 : Convert.ToInt16(v1) * v2;
        }

        public int RaizCuadrada(int v1, int v2)
        {
            return  v1 ^ (v2);
        }

        public double Potencia(int v1, int v2)
        {
            return Math.Pow(v1, v2); 
        }
        
        public int Dividir(int v1, int v2)
        {
            return v1 / v2;
        }

        public double DividirB(int v1, int v2)
        {
            double d = v1 / v2;
            return Math.Floor(d);
        }

        public int DividirC(int v1, int v2)
        {
           return v1 % v2;
        }
    }
}
