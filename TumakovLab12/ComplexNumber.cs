using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumakovLab12
{
    internal class ComplexNumber
    {
        private double material;
        private double imaginary;
        public ComplexNumber(double material, double imaginary)
        {
            this.material = material;
            this.imaginary = imaginary;
        }
        public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
        {
            double mat = a.material + b.material;
            double imag = a.imaginary + b.imaginary;
            return new ComplexNumber(mat, imag);
        }
        public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
        {
            double mat = a.material - b.material;
            double imag = a.imaginary - b.imaginary;
            return new ComplexNumber(mat, imag);
        }
        public static ComplexNumber operator *(ComplexNumber a, ComplexNumber b)
        {
            double mat = a.material * b.material - a.imaginary * b.imaginary;
            double imag = a.material * b.imaginary + a.imaginary * b.material;
            return new ComplexNumber(mat, imag);
        }
        public static bool operator ==(ComplexNumber a, ComplexNumber b)
        {
            return a.material == b.material && a.imaginary == b.imaginary;
        }

        public static bool operator !=(ComplexNumber a, ComplexNumber b)
        {
            return !(a == b);
        }
        public override string ToString()
        {
            return $"{material} + {imaginary}i";
        }
    }
}
