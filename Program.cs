/*
// Задача №41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int [] GetArr(int m)
{
  int [] arr = new int[m];
  for (int i = 0; i < m; i++)
  {
    Console.Write($"Введите число номер {i+1}: ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
  }
  return arr;
}

void Counting(int [] arr)
{
  int res = 0;
  for (int i = 0; i < arr.Length; i++)
  {
  if (arr[i] > 0)
    {
      res++;
      Console.Write($"{arr[i]} ");
    }
  }
  Console.Write($"Всего чисел больше нуля: {res}");
}
 
Console.Write("Введите количество чисел: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Counting(GetArr(m1));
*/
//----------------------------------------------------------
/*
// Задача №43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Crossing(double b1, double b2, double k1, double k2)
{
  if (k1 != k2)
  {
    double x = (b1 - b2) / -(k1 - k2) ;
    double y = k1 * x + b1;
    Console.WriteLine($"Линии пересекаются в точке ({x}, {y}).");
  }
  else
  {
    Console.WriteLine($"У линий нет точек пересечения!");
  }
}

Console.WriteLine("y1 = k1 * x + b1");
Console.WriteLine("y2 = k2 * x + b2");

Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Crossing(b1, b2, k1, k2);
*/
//----------------------------------------------------------