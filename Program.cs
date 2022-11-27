/*
// Задача №54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int [,] TooManyArrays(int m, int n)
{
  int [,] arr = new int[n, m];
  Console.WriteLine($"Введённый массив: ");

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

void Sorting (int [,] arr)
{
  Console.Write($"\n");
  Console.Write($"\n");
  int rows = arr.GetUpperBound(0) + 1;
  int cols = arr.Length / rows;

  for (int g = 0; g < rows; g++)
  {

    for (int c = 0; c < cols; c++)
    {

      for (int p = 0; p < cols-1; p++)
      {

        if (arr[g, p] < arr[g,p+1])
        {
          int temp = arr[g, p];
          arr[g, p] = arr[g, p+1];
          arr[g, p+1] = temp;
        }
      }
    }
  }
  Console.WriteLine($"Изменённый массив: ");
  for (int f = 0; f < rows; f++)
  {
    Console.Write($"\n");
    for (int h = 0; h < cols; h++)
    {
      Console.Write($"{arr[f, h]}   ");
    }
  }
}
 
Console.Write("Введите m: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n1 = Convert.ToInt32(Console.ReadLine());

Sorting(TooManyArrays(m1, n1));
*/
//----------------------------------------------------------
/*
// Задача №56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] TooManyArrays(int m, int n)
{
  int [,] arr = new int[n, m];
  Console.WriteLine($"Введённый массив: ");

  for (int i = 0; i < n; i++)
  {
    Console.Write($"\n");
    for (int j = 0; j < m; j++)
    {
      arr[i, j] = new Random().Next(0, 10);
      Console.Write($"{arr[i, j]}   ");
    }
  }
  Console.Write($"\n");
  Console.Write($"\n");
  return arr;
}

int[] SomeRows(int[,] arr) 
{
  int[] calcArr = new int[arr.GetLength(0)];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      sum += arr[i, j];
    }
    Console.WriteLine($"Сумма элементов в {i + 1} строчке: {sum} ");
    calcArr[i] = sum;
  }
  return calcArr;
}

Console.Write("Введите m: ");
int m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n: ");
int n1 = Convert.ToInt32(Console.ReadLine());

int[,] someArr = TooManyArrays(m1, n1);

int[] sumArr = SomeRows(someArr);
int min = sumArr[0];

int min1 = 0;
for (int i = 1; i < sumArr.Length; i++)
{
    if (sumArr[i] < min)
    {
        min = sumArr[i];
        min1 = i;
    }
}
Console.Write($"Наименьшая сумма элементов в {min1 + 1} строке.");
*/
//----------------------------------------------------------
/*
// Задача №62. Напишите программу, которая заполнит спирально массив 4 на 4.

int rows = 4;
int cols = 4;

void TooManyArrays(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++) 
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {

        Console.Write($"{arr[i, j], 3} ");

    }
    Console.WriteLine();
  }
}
int SpiralArr(int[,] newArr, int count, int iE, int jE) 
{
 
    for (int j = jE; j < cols; j++)
    {
        if (newArr[iE, j] == 0) 
        {
          newArr[iE, j] = count;
        }
        count++;
    }
    
    for (int i = iE + 1; i < rows; i++)
    {
        if (newArr[i, cols - 1] == 0)
        {
          newArr[i, cols - 1] = count;
        }
        count++;
    }
 
    for (int j = cols - 2; j >= jE; j--) 
    {
        if (newArr[rows - 1, j] == 0)
        {
          newArr[rows - 1, j] = count;
        }
        count++;
    }
 
    for (int i = rows - 2; i > iE; i--)
    {
        if (newArr[i, jE] == 0)
        {
          newArr[i, jE] = count;
        }
        count++;
    }
   
    return count;
}

int[,] someSpiralArray = new int[rows, cols];
int i1 = 0;
 int j1 = 0;
int value = 1;

while (rows > 1 & cols > 1)
{
  value = SpiralArr(someSpiralArray, value, i1, j1);
  i1++;
  j1++;
  rows--;
  cols--;
   
}
 
TooManyArrays(someSpiralArray);
*/