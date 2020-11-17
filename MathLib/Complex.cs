using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
    public class Complex
    {
        private int real;
        private int imag;
        public Complex()
        {
            
        }
        public Complex(int r, int i)
        {
            real = r;
            imag = i;
        }
        public static Complex operator+ (Complex c1,Complex c2)
        {
            Complex temp = new Complex(); //default Ctor Obj
            temp.real = c1.real + c2.real;
            temp.imag = c1.imag + c2.imag;
            return temp;
        }
    }
}
