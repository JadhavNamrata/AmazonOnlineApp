using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//in Library write reusable function
namespace MathLib
{
    //static class ----obj cannot created -----all methods should be static
    static public class MathEngine
    {
        public static int Add(int op1, int op2)
        {
            int result = op1 + op2;
            return result;
        }
        public static int Substract(int op1, int op2)
        {
            int result = op1 - op2;
            return result;
        }
        public static int Multiplication(int op1, int op2)
        {
            int result = op1 * op2;
            return result;
        }
    }
}
