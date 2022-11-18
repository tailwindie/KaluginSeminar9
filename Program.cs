/*
// Задача №47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double [,] GetArray(int m, int n)
{
  double [,] arr = new double[m, n];
  Console.WriteLine($"Ваш массив: ");
  for (int i = 0; i < m; i++)
  {
    Console.Write($"\n");
    for (int j = 0; j < n; j++)
    {
      arr[i, j] = Math.Round(new Random().NextDouble(), 1);
      arr[i, j] += new Random().Next(0, 100);
      Console.Write($"{arr[i, j]}   ");
    }
  }
  return arr;
}
 
Console.Write("Введите m: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n1 = Convert.ToInt32(Console.ReadLine());

GetArray(m1, n1);
*/
//----------------------------------------------------------
/*
// Задача №50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

double [,] GetArray(int n, int m)
{
  double [,] arr = new double[n, m];
  Console.WriteLine($"Ваш массив: ");
  for (int i = 0; i < n; i++)
  {
    Console.Write($"\n");
    for (int j = 0; j < m; j++)
    {
      arr[i, j] = Math.Round(new Random().NextDouble(), 1);
      arr[i, j] += new Random().Next(0, 100);
      Console.Write($"{arr[i, j]}   ");
    }
  }
  return arr;
}

void Checkout (double [,] arr)
{
  Console.Write($"\n");
  Console.Write($"\n");
  Console.Write("Введите позицию элемента m: ");
  int m2 = Convert.ToInt32(Console.ReadLine());

  Console.Write("Введите позицию элемента n: ");
  int n2 = Convert.ToInt32(Console.ReadLine());

  int rows = arr.GetUpperBound(0) + 1;
  int cols = arr.Length / rows;
  if (m2 > rows || n2 > cols)
  {
    Console.Write($"Такого элемента нет!");
  }
  else
  {
    Console.Write($"Ваш элемент: {arr[m2-1, n2-1]}");
  }
}

 
Console.Write("Введите m: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Checkout(GetArray(m1, n1));
*/
//----------------------------------------------------------
/*
// Задача №52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int [,] TooManyArrays(int m, int n)
{
  int [,] arr = new int[n, m];
  Console.WriteLine($"Ваш массив: ");

  for (int i = 0; i < n; i++)
  {
    Console.Write($"\n");
    for (int j = 0; j < m; j++)
    {
      arr[i, j] = new Random().Next(0, 10);
      Console.Write($"{arr[i, j]}   ");
    }
  }
  return arr;
}

void Checkout (int [,] arr)
{
  Console.Write($"\n");
  Console.Write($"\n");
  int rows = arr.GetUpperBound(0) + 1;
  int cols = arr.Length / rows;

  double []resArr = new double[cols];

  for (int g = 0; g < cols; g++)
  {
    
    for (int p = 0; p < rows; p++)
    {
      resArr[g] += arr[p, g];
      
    }
  }
  for (int f = 0; f < cols; f++)
  {
      resArr[f] /= rows;
      resArr[f] = Math.Round(resArr[f], 1);
      Console.Write($"{resArr[f]}   ");
  }
}
 
Console.Write("Введите m: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Checkout(TooManyArrays(m1, n1));
*/