using System;

namespace ConsoleCalculator {
    class Program {
        static void Main(string[] args) {
            double a, b, calc;
            char sign;
            try {
                Console.WriteLine("ВВЕДИТЕ ПЕРВОЕ ЧИСЛО:");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("ВВЕДИТЕ ОПЕРАТОР:");
                sign = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("ВВЕДИТЕ ВТОРОЕ ЧИСЛО:");
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
