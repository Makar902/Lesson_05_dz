using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1.Реализовать класс для хранения комплексного
//числа. Выполнить в нем перегрузку всех
//необходимых операторов для успешной компиляции
//следующего фрагмента кода:    
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex z = new Complex(1, 1);
            Complex z1;
            z1 = z - (z * z * z - 1) / (3 * z * z);

            Console.WriteLine("z1 = {0}", z1);
        }
    }
    public class Complex
    {
        public dynamic x;
        public dynamic y;

        public Complex(dynamic x, dynamic y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return string.Format(" {0} + i {1};", x, y);
        }

        public static dynamic operator *(Complex a, Complex b)
        {
            return new Complex(a.x * b.x - a.y * b.y, a.y * b.x + a.x * b.y);
        }

        public static dynamic operator *(dynamic a, Complex b)
        {
            return new Complex(a * b.x, a * b.y);
        }

        public static dynamic operator *(Complex b, dynamic a)
        {
            return a * b;
        }

        public static dynamic operator /(Complex a, Complex b)
        {
            return new Complex((a.x * b.x + a.y * b.y) / (b.x * b.x + b.y * b.y), (a.y * b.x - a.x * b.y) / (b.x * b.x + b.y * b.y));
        }

        public static dynamic operator -(Complex a, dynamic b)
        {
            return new Complex(a.x - b, a.y - b);
        }

        public static dynamic operator -(Complex a, Complex b)
        {
            return new Complex(a.x - b.x, a.y - b.y);
        }
    }
}
