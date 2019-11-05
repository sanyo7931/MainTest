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
            float result = -1;
            try
            {
                if (n1 < 0)
                {
                    throw new ArgumentOutOfRangeException("n1 必須為正整數");
                }

                if (n2 == 0)
                {
                    throw new DivideByZeroException();
                }

                result = (float)n1 / (float)n2;
            }
            catch (DivideByZeroException exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
            catch (ArgumentOutOfRangeException exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.ToString());
                throw;
            }
            return result;
        }
    }
}
