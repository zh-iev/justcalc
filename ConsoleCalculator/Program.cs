using System;

namespace ConsoleCalculator {
    class Program {
        static void Main(string[] args) {
            double a, b, calc;
            char sign;
            try {
                Console.WriteLine("Введите первое число:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введите оператор:");
                sign = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Введите второе число:");
                b = Convert.ToDouble(Console.ReadLine());

                switch (sign) {
                    case '+':
                        calc = a + b;
                        Console.WriteLine(a + " + " + b + " = " + calc);
                        break;
                    case '-':
                        calc = a - b;
                        Console.WriteLine(a + " - " + b + " = " + calc);
                        break;
                    case '*':
                        calc = a * b;
                        Console.WriteLine(a + " * " + b + " = " + calc);
                        break;
                    case '/':
                        if (b == 0) {
                            Console.WriteLine("Деление на ноль невозможно.");
                        }
                        else {
                            calc = a / b;
                            Console.WriteLine(a + " / " + b + " = " + calc);
                        }
                        break;
                    case 'l':
                        calc = Math.Log(a, b);
                        Console.WriteLine("Логарифм с основанием {0} от числа {1} = {2}",b,a,calc);
                        break;
                    case 'm':
                        calc = Math.Max(a, b);
                        Console.WriteLine(calc + " большее из " + a + " и " + b);
                        break;
                    default:
                        Console.WriteLine("Введите корректный оператор!");
                        break;
                }
            }
            catch {
                Console.WriteLine("Ошибка, попробуйте снова.");
            }
        }
    }
}
