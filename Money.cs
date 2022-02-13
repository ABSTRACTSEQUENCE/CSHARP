using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1. Создать C# проект командной строки в Visual Studio или иной IDE.
2. Добавьте класс Money, содержащий поля:
•	CurrencyCode – код валюты (“rub”, “usd” и т.д.)
•	Amount – номинал данного объекта Money (сколько денег то).
3. Реализуйте конструктор класса, необходимые свойства, переопределите метод ToString.
4. Добавьте в класс описание делегата:
public double MoneyConvertDelegate(double value).
5. Добавьте  в класс метод, принимающий в качестве параметра делегат типа, который указан выше. Данный метод должен делать вызов переданного делегата (через GetinvocationsList).
6. В Main создайте объект класса Money и объект делегата MoneyConvertDelegate.
7. Добавьте в созданный делегат анонимный метод для конвертации долларов в рубли, выполнив:
del += delegate(double amount) { 
	Console.WriteLine($”{amount}$ = {amount * k} руб”);
} где k – отношение курса одной валюты к другой.
8. Аналогичным образом добавьте еще 3 конвертера из долларов в произвольную валюту, используя анонимные методы.
9. Протестируйте, выполнив вызов метода с передачей делегата в качестве параметра.
Бонусное задание (по желанию):
10. Добавьте в созданный ранее делегат лямбду для конвертации долларов в золото.
11. Еще раз все протестировать. 
*/
namespace CSharpSandBox
{
    class Money
    {
        private string currency_code { get; set; }
        double amount { get; set; }

        public Money(string code, double amount)
        {
            currency_code = code;
            this.amount = amount;
        }

        public delegate double MoneyConvertDel (double value, string code);

        public object Call(MoneyConvertDel del, string to)
        {
            int i = 0; //итератор нужен для того, чтобы выбрать какой метод использовать
            switch (currency_code)
            {
                case "rub":
                    i = 0;
                    break;
                case "usd":
                    i = 1;
                    break;
                case "eur":
                    i = 2;
                    break;
                default: return 0;
            }
            if (i != 0 && i != 1 && i != 2)//если по какой-то причине значение итератора не будет соответствовать нужным нам числам, то вернёт 0
                return 0;
            else
                return del.GetInvocationList()[i].DynamicInvoke(amount, to);//через GetInvokationList и итератор, объявленный в начале, выбираем необходимый нам метод
        }

        public override string ToString()
        {
            return $"Currency code: {currency_code}\nAmount: {amount}";
        }
    }
}
