using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prKol_ind3_v2_Khokhlov
{
    public class CNumbers
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public CNumbers(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }
        public CNumbers Add(CNumbers other)
        {
            return new CNumbers(this.Real + other.Real, this.Imaginary + other.Imaginary);
        }
        public CNumbers Substract(CNumbers other)
        {
            return new CNumbers(this.Real - other.Real, this.Imaginary - other.Imaginary);
        }
        public CNumbers Multiply(CNumbers other)
        {
            return new CNumbers(this.Real * other.Real - this.Imaginary * other.Imaginary, this.Real * other.Imaginary + this.Imaginary * other.Real);
        }
        public override string ToString()
        {
            if (Imaginary >= 0)
                return $"{Real} + {Imaginary}i";
            else
                return $"{Real} - {Math.Abs(Imaginary)}i";
        }
    }
}
