using System;

namespace ConsoleCalculator {
    class Program {
        static void Main(string[] args) {
            double a, b, calc;
            char sign;
            Console.WriteLine("Привет! Это простой консольный калькулятор. \n" +
                "Следуй указаниям, чтобы получить верный результат\n" +
                "Используй знак + для сложения, - для вычитания,\n" +
                "* для умножения, / для деления,\n" +
                "^ для возведения в степень, m для определения максимума, \n" +
                "l для вычисления логарифма от первого числа по основанию второго.\n\n");
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
                    case '^':
                        calc = Math.Pow(a, b);
                        Console.WriteLine(a + " в степени " + b + " = " + calc);
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
