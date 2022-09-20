// Вычислить значение функции y при заданном значении аргумента x по формуле у = 0
// если модуль(x) >= 1, или у = x^2 – 1, если модуль(x) < 1.

using System;
class Program {
  static void Main() {
        double x, y;
        x = double.Parse(Console.ReadLine());
        if (Math.Abs(x) >= 1){
            y = 0;
            Console.WriteLine(y);
        }
        if (Math.Abs(x) < 1){
            y = x*x-1;
            Console.WriteLine(y);
        }
  }
}
