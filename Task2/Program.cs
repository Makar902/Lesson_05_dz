using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. Разработать класс Fraction, представляющий простую
//дробь . в классе предусмотреть два поля: числитель
//и знаменатель дроби. Выполнить перегрузку следующих операторов: +,-,*,/,==,!=,<,>, true и false.
//Арифметические действия и сравнение выполняется
//в соответствии с правилами работы с дробями. Оператор true возвращает true если дробь правильная
//(числитель меньше знаменателя), оператор false
//возвращает true если дробь неправильная (числитель
//больше знаменателя).
//Выполнить перегрузку операторов, необходимых для
//успешной компиляции следующего фрагмента кода:
namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(3, 4);
            f.Print();
            Console.WriteLine("--------------------");
            int a = 10;
            Fraction f1 = f * a;
            f1.Print();
            Console.WriteLine("--------------------");

            Fraction f2 = a * f;
            f2.Print();
            Console.WriteLine("--------------------");

            double d = 1.5;
            Fraction f3 = f + d;
            f3.Print();
            Console.WriteLine("--------------------");

            Fraction f4 = f-1;
            f4.Print();
            Console.WriteLine("--------------------");

            Fraction f5 = f/2;
            f5.Print();
            Console.WriteLine("--------------------");

            Fraction f6 = f;
            f6.Print();
            Console.WriteLine(f6==f);
            Console.WriteLine(f6!=f);
            Console.WriteLine("--------------------");


            Fraction f7 = f;
            f7.Print();
            Console.WriteLine(f7>f4);
            Console.WriteLine("--------------------");

        }
    }
    public class Fraction
    {
        public dynamic x;
        public dynamic y;
        private static object c1;

        public Fraction(dynamic x, dynamic y)
        {
            this.x=x;
            this.y=y;

        }
        public dynamic Print()
        {
            Console.Write(x);
            Console.Write("/");
            Console.WriteLine(y);
            return 0;
        }
        public static dynamic operator*(Fraction c1, dynamic c2)
        {
            return new Fraction((c1.x*c2),(c1.y*c2));
        }
        public static dynamic operator *(dynamic c1, Fraction c2)
        {
            return new Fraction((c1*c2.x), (c1*c2.y));
        }

        public static dynamic operator +(Fraction c1, dynamic c2)
        {
#pragma warning disable CS1717 // Назначение выполнено для той же переменной
            return new Fraction((c1.x+(c2*c1.y)), c1.y=c1.y);
#pragma warning restore CS1717 // Назначение выполнено для той же переменной
        }
        public static dynamic operator +(dynamic c2, Fraction c1)
        {
#pragma warning disable CS1717 // Назначение выполнено для той же переменной
            return new Fraction((c1.x+(c2*c1.y)), c1.y=c1.y);
#pragma warning restore CS1717 // Назначение выполнено для той же переменной
        }

        public static dynamic operator -(Fraction c1, dynamic c2)
        {
#pragma warning disable CS1717 // Назначение выполнено для той же переменной
            return new Fraction((c1.x-(c2*c1.y)), c1.y=c1.y);
#pragma warning restore CS1717 // Назначение выполнено для той же переменной
        }
        public static dynamic operator -(dynamic c2, Fraction c1)
        {
#pragma warning disable CS1717 // Назначение выполнено для той же переменной
            return new Fraction((c1.x-(c2*c1.y)), c1.y=c1.y);
#pragma warning restore CS1717 // Назначение выполнено для той же переменной
        }

        public static dynamic operator /(Fraction c1, dynamic c2)
        {
            return new Fraction((c1.x*1), (c1.y*c2));
        }
        public static dynamic operator /(dynamic c1, Fraction c2)
        {
            return new Fraction((c1.x*1), (c1.y*c2));
        }

        public static dynamic operator ==(Fraction c1, Fraction c2)
        {
           return (c1.x == c2.x) && (c1.y == c2.y);
        }
        public static dynamic operator !=(Fraction c1, Fraction c2)
        {
            return (c1.x != c2.x) && (c1.y != c2.y);
        }

        public static dynamic operator >(Fraction c1, Fraction c2)
        {
            if(c1.x==c2.x)
            {
                return c1.y > c2.y;
            }
            else if(c1.y==c2.y)
            {
                return c1.x>c2.x;
            }
            else
            {
                if(c1.y>c2.y)
                {
                    c2.y*=c1.y;
                    return c1.x>c2.x;
                }
            }
            return null;
        }
        public static dynamic operator <(Fraction c1, Fraction c2)
        {
            if (c1.x==c2.x)
            {
                return c1.y < c2.y;
            }
            else if (c1.y==c2.y)
            {
                return c1.x<c2.x;
            }
            else
            {
                if (c1.y<c2.y)
                {
                    c2.y*=c1.y;
                    return c1.x<c2.x;
                }
            }
            return null;
        }

        //я не смог разобраться как перегрузить true и false
        //public static dynamic operator true(Fraction c2)
        //{
        //    if (0==c2.x && 0==c2.y)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public static dynamic operator false(Fraction c2)
        //{
            
        //    return false;
        //}
    }
}
