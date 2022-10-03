// Вычислить значение функции y при заданном значении аргумента x по формуле y = 1,
// если х <= –1, или у = -х, если 1 < x <= 1, или y = -1, если х > 1.

using System;
class Program {
  static void Main() {
        double x, y;
        x = double.Parse(Console.ReadLine());
        if (x <= -1){
            y = 1;
            Console.WriteLine(y);
        }
        if ( x <= 1){
            if (1< x){
                y = -x;
                Console.WriteLine(y);
        }}
        if (x>1){
            y = -1;
            Console.WriteLine(y);
        }
  }
}
