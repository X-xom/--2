// В компьютер вводятся по очереди координаты n точек. Определить, сколько из них попадет в кольцо с внутренним радиусом r1 и внешним r2 .

using System;
class Program {
  static void Main() {
      double a1, b1, a2, b2, x, y, r1, r2, point;
      int answer = 0;
      Console.WriteLine("Введите 1-ый радиус");
      r1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите 2-ой радиус");
      r2 = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите a 1-ого круга");
      a1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите b 1-ого круга");
      b1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите a 2-ого круга");
      a2 = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите b 2-ого круга");
      b2 = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите количество точек");
      point = int.Parse(Console.ReadLine());
      for (int i = 1; i<= point; i++){
          Console.WriteLine("Введите координату x");
          x = double.Parse(Console.ReadLine());
          Console.WriteLine("Введите координату y");
          y = double.Parse(Console.ReadLine());
          if ((x-a2) * (x-a2) + (y-b2) * (y-b2) <= r2 * r2){
              if ((x-a1) * (x-a1) + (y-b1) * (y-b1) > r1 * r1){
                  answer += 1;
              }
          }
      }
      Console.WriteLine("Количество точек входящих в круг:");
      Console.WriteLine(answer);
  }
}
