using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandBox
{
    class Money
    {
        int rub;
        int kop;

        public Money(int rub, int kop = 0)
        {
            this.rub = rub;
            this.kop = kop;
        }
        public Money(double value)
        {
            string[] str;
            str = value.ToString().Split(',');
            rub = Convert.ToInt32(str[0]);
            kop = Convert.ToInt32(str[1]);
        }

        static public Money operator +(Money a, int b)
        {
            Console.WriteLine($"Пополнение на {b} рублей");
            Money value = new Money(a.rub + b, a.kop);
            return value;
        }
        static public Money operator +(Money a, decimal b)
        {
            string[] str;
            str = b.ToString().Split(',');
            Money value = new Money(a.rub + Convert.ToInt32(str[0]), Convert.ToInt32(str[1]));
            if (value.kop >= 100){
                while (value.kop >= 100) {
                    value.kop -= 100;
                    value.rub++;
                }
            }
            Console.Write($"Пополнение на  {str[0]} рублей");
            if (value.kop > 0)
                Console.WriteLine($" {str[1]} копеек");
            else Console.WriteLine();
            return value;
        }
        static public Money operator -(Money a, int b)
        {
            Console.WriteLine($"Пополнение на {b} рублей");
            Money value = new Money(a.rub - b, a.kop);
            return value;
        }
        static public Money operator -(Money a, decimal b)
        {
            string[] str;
            str = b.ToString().Split(',');
            a.kop = Convert.ToInt32(str[1]);
            a.rub -= Convert.ToInt32(str[0]);
            if (a.kop >= 100)
            {
                while (a.kop >= 100)
                {
                    a.kop -= 100;
                    a.rub++;
                }
            }
            Console.Write($"Снятие {str[0]} рублей");
            if (a.kop > 0)
                Console.WriteLine($" {str[1]} копеек");
            else Console.WriteLine();
            return a;
        }
        static public Money operator /(Money a, int b)
        {
            a.rub /=b;
            Console.WriteLine($"Деление на {b} рублей");
            return a;
        }
        static public Money operator /(Money a, decimal b)
        {
            string[] str;
            str = b.ToString().Split(',');
            a.kop = Convert.ToInt32(str[1]);
            a.rub /= Convert.ToInt32(str[0]);
            if (a.kop >= 100)
            {
                while (a.kop >= 100)
                {
                    a.kop -= 100;
                    a.rub++;
                }
            }
            Console.Write($"Деление на {str[0]} рублей");
            if (a.kop > 0)
                Console.WriteLine($" {str[1]} копеек");
            else Console.WriteLine();
            return a;
        }
        static public Money operator *(Money a, int b)
        {
            a.rub *= b;
            Console.WriteLine($"Умножение на {b} рублей");
            return a;
        }
        static public Money operator *(Money a, decimal b)
        {
            string[] str;
            str = b.ToString().Split(',');
            a.kop = Convert.ToInt32(str[1]);
            a.rub /= Convert.ToInt32(str[0]);
            if (a.kop >= 100)
            {
                while (a.kop >= 100)
                {
                    a.kop -= 100;
                    a.rub++;
                }
            }
            Console.Write($"Умножение на {str[0]} рублей");
            if (a.kop > 0)
                Console.WriteLine($" {str[1]} копеек");
            else Console.WriteLine();
            return a;
        }
        static public Money operator ++(Money a)
        {
            a.kop++;
            Console.WriteLine("Пополнение на 1 копейку");
            return a;
        }
        static public Money operator --(Money a)
        {
            a.kop++;
            Console.WriteLine("Снятие 1 копейки");
            return a;
        }
        static public bool operator > (Money a, Money b)
        {
            if (a.rub == b.rub)
            {
                if (a.kop > b.kop)
                    return false;
            }
            if (a.rub > b.rub)
                 return false;

            else return true;
        }
        static public bool operator > (Money a, int b)
        {
            if (a.rub > b)
                return true;
            else return false;
        }
        static public bool operator <(Money a, int b)
        {
            if (a.rub < b)
                return true;
            else return false;
        }
        static public bool operator <(Money a, Money b)
        {
            if (a.rub == b.rub && a.kop < b.kop)
                return true;
            else  if (a.rub < b.rub)
                return true;

            else return false;
        }
        static public bool operator ==(Money a, Money b)
        {
            if (a.rub == b.rub && a.kop == b.kop)
                 return true;
            else return false;
        }
        static public bool operator !=(Money a, Money b)
        {
            if (a.rub == b.rub && a.kop == b.kop)
                return false;
            else return true;
        }

        public override string ToString()
        {
                if (kop > 0)
                return $"Баланс: {rub} рублей {kop} копеек";
                else
                return $"Баланс: {rub} рублей"; ;
        }
    }
}
