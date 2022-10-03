// В компьютер вводятся по очереди координаты n точек. Определить, сколько из них попадет в круг радиусом r с центром в точке (a, b).

using System;
class Program {
  static void Main() {
      double a, b, x, y, r, point;
      int answer = 0;
      Console.WriteLine("Введите радиус");
      r = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите a");
      a = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите b");
      b = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите количество точек");
      point = int.Parse(Console.ReadLine());
      for (int i = 1; i<= point; i++){
          Console.WriteLine("Введите x");
          x = double.Parse(Console.ReadLine());
          Console.WriteLine("Введите y");
          y = double.Parse(Console.ReadLine());
          if ((x-a) * (x-a) + (y-b) * (y-b) <= r * r){
              answer += 1;
          }
      }
      Console.WriteLine("Количество точек входящих в круг:");
      Console.WriteLine(answer);
  }
}
