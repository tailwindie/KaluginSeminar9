/*
// Задача №34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] GetArray(int n)
{
  int [] arr = new int[n];
  for (int i = 0; i < n; i++)
  {
    arr[i] = new Random().Next(100 , 1000);
  }
  return arr;
}

void ShowCount(int [] arr)
{
  int res = 0;
  Console.Write($"Ваш массив: ");
  for( int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{arr[i]} ");

    if (arr[i] % 2 == 0)
    {
      res += 1;
    }
  }
  Console.Write($". Количество чётных чисел = {res}.");
}
 
Console.Write("Введите размер массива: ");
int n1 = Convert.ToInt32(Console.ReadLine());

ShowCount(GetArray(n1));
*/
//----------------------------------------------------------

// Задача №36. Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] GetArray(int n)
{
  int [] arr = new int[n];
  for (int i = 0; i < n; i++)
  {
    arr[i] = new Random().Next();
  }
  return arr;
}

void ShowCount(int [] arr)
{
  int res = 0;
  Console.Write($"Ваш массив: ");
  for( int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{arr[i]} ");

    if (i % 2 == 0)
    {
      res += arr[i];
    }
  }
  Console.Write($". Сумма чисел на нечётных позициях = {res}.");
}
 
Console.Write("Введите размер массива: ");
int n1 = Convert.ToInt32(Console.ReadLine());

ShowCount(GetArray(n1));
*/
//----------------------------------------------------------
/*
// Задача №38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] GetArray(int n)
{
  double [] arr = new double[n];
  for (int i = 0; i < n; i++)
  {
    arr[i] = Math.Round(new Random().NextDouble(), 1);
    arr[i] += new Random().Next(0, 100);
  }
  return arr;
}

void ShowCount(double [] arr)
{
  double maxArr = arr[0];
  double minArr = arr[0];
  
  Console.Write($"Ваш массив: ");
  for( int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  for( int j = 1; j < arr.Length; j++)
  {
    if (arr[j] > arr[j-1])
    {
      maxArr = arr[j];
    }
    else if (arr[j] < arr[j-1])
    {
      minArr = arr[j];
    }
  }
  double res = Math.Round(maxArr - minArr, 1);
  Console.Write($". Разница между максимальным и минимальным элементами массива = {maxArr} - {minArr} = {res}.");
}

Console.Write("Введите размер массива: ");
int n1 = Convert.ToInt32(Console.ReadLine());

ShowCount(GetArray(n1));
*/