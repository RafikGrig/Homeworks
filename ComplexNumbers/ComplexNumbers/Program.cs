 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            re a1 = new re(4.1);
            re b1 = new re(2.3);
            re c1 = a1.Div(b1);
            Console.WriteLine(c1.value);

            im a2 = new im(-3.5);
            im b2 = new im(2);
            im c2 = a2.Multy(b2);
            Console.WriteLine(c2.value);

            Complex com1 = new Complex(a1,a2);
            Complex com2 = new Complex(b1, b2);
            Complex com = com1 + com2;
            Console.WriteLine(com);
            com = com1 -com2;
            Console.WriteLine(com);
            com = com1 * com2;
            Console.WriteLine(com);
            com = com1 / com2;
            Console.WriteLine(com);
            Console.WriteLine(com.Magnitude());
        }
    }

    class Complex
    {
        private re real;
        public re Real { get => real; set => real = value; }
        private im imaginary;
        public im Imaginary { get => imaginary; set { if (value.value != 0) imaginary = value; } }
        
        public Complex(re r, im i)
        {
            Real = r;
            Imaginary = i;
        }

        public override string ToString()
        {
            if (this.Real.value == 0)
                return this.Imaginary.value + "i";
            if (this.Imaginary.value>0)
                return this.Real.value + "+" + this.Imaginary.value + "i";
            else
                return this.Real.value + "" + this.Imaginary.value + "i";
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
             return new Complex(c1.Real.Sum(c2.Real), c1.Imaginary.Sum(c2.Imaginary));
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real.Sub(c2.Real), c1.Imaginary.Sub(c2.Imaginary));
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.Real.Multy(c2.Real), c1.Imaginary.Multy(c2.Imaginary));
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            return new Complex(c1.Real.Div(c2.Real), c1.Imaginary.Div(c2.Imaginary));
        }

        public double Magnitude()
        {
            return Math.Sqrt(this.Real.value * this.Real.value + this.Imaginary.value * this.Imaginary.value);
        }
    }

    struct re
    {
        public double value;        
        public re(double v)
        {
            value = v;
        }
        public re Sum(re r1)
        {
            re r = new re();
            r.value = this.value + r1.value;
            return r;
        }
        public re Sub(re r1)
        {
            re r = new re();
            r.value = this.value - r1.value;
            return r;
        }
        public re Multy(re r1)
        {
            re r = new re();
            r.value = this.value * r1.value;
            return r;
        }
        public re Div(re r1)
        {
            re r = new re();
            if (r1.value != 0)
                r.value = this.value / r1.value;
            else
                Console.WriteLine("error, second value =0");
            return r;
        }
    }
    struct im
    {
        public double value;
        public im(double v)
        {
            value = v;
        }
        public im Sum(im r1)
        {
            im r = new im();
            r.value = this.value + r1.value;
            return r;
        }
        public im Sub(im r1)
        {
            im r = new im();
            r.value = this.value - r1.value;
            return r;
        }
        public im Multy(im r1)
        {
            im r = new im();
            r.value = this.value * r1.value;
            return r;
        }
        public im Div(im r1)
        {
            im r = new im();            
            r.value = this.value / r1.value;           
            return r;
        }
    }
}
