using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operadores
    {
        public double A;
        public double B;
        public double resultado { get; set; }
        public double Adicao()
        {
            resultado = A + B;
            return resultado;
        }
        public double Subtracao()
        {
            resultado = A - B;
            return resultado;
        }
        public double Multiplicacao()
        {
            resultado = A * B;
            return resultado;
        }
        public double Divisao()
        {
            resultado = A / B;
            return resultado;
        }
        public double Porcento()
        {
            resultado = (A / 100.0) * B;
            return resultado;
        }
    }
}
