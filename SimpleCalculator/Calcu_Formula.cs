using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public delegate int GetAnswer(int num1,int num2);
    class Calcu_Formula
    {
            public static int GetSum(int num1, int num2)
            {
                return num1 + num2;
            }

            public static int GetDifference(int num1, int num2)
            {
                return num1 - num2;
            }
            public static int GetQuotient(int num1, int num2)
            {
                return num1 / num2;
            }
            public static int GetProduct(int num1, int num2)
            {
                return num1 * num2;
            }
        }
}
