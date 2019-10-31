using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDemo
{
    public class Calculator
    {
        public int Add(int n1, int n2)
        {
            return n1 + n2;
        }
        public int Sub(int n1, int n2)
        {
            return n1 - n2;
        }
        public int Mul(int n1, int n2)
        {
            return n1 * n2;
        }
        public float Div(int n1, int n2)
        {
            return (float)n1 / (float)n2;
        }
    }
}
