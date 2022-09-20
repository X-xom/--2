// Вычислить значение функции y при заданном значении аргумента x по формуле у = 0
// если х <= –1, или у = 1 + х, если –1 < x <= 0, или y = 1, если х > 0.

using System;
class Program {
  static void Main() {
        double x, y;
        x = double.Parse(Console.ReadLine());
        if (x <= -1){
            y = 0;
            Console.WriteLine(y);
        }
        if ( x <= 0){
            if (-1< x){
                y = 1+x;
                Console.WriteLine(y);
        }}
        if (x>0){
            y = 1;
            Console.WriteLine(y);
        }
  }
}
