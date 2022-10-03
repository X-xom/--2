// Ученику 1-го класса назначается дополнительно стакан молока (200 мл), если его вес составляет меньше 30 кг. Определить, сколько литров молока потребуется
// ежедневно для одного класса, состоящего из n учеников. После взвешивания вес каждого ученика вводится в компьютер.

using System;
class Program {
  static void Main() {
      double students, x;
      double liters = 0;
      Console.WriteLine("Введите количество учеников");
      students = int.Parse(Console.ReadLine());
      for (int i = 1; i<= students; i++){
          Console.WriteLine("Введите вес ученика");
          x = double.Parse(Console.ReadLine());
          if (x<30){
              liters += 0.2;
          }
      }
      Console.WriteLine("Количество литров молока в день:");
      Console.WriteLine(liters);
  }
}
