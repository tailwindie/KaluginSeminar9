/*
// Задача №64. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

string NaturalNumbers(int m1, int n1)
{
    if (m1 <= n1) return $"{m1}   " + NaturalNumbers(m1 + 1, n1);
    else return String.Empty;
}
Console.WriteLine(NaturalNumbers(m, n));
*/
//----------------------------------------------------------
/*
// Задача №66. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int NaturNumsSum(int m1, int n1)
{
    if (m1 != n1 + 1) return m1 + NaturNumsSum(m1 + 1, n1) ; 
    else return 0;
}
Console.WriteLine($"Cумма всех натуральных чисел в промежутке от {m} до {n} = {NaturNumsSum(m, n)} ");
*/
//----------------------------------------------------------
/*
// Задача №68.  Напишите программу вычисления функции Аккермана с помощью рекурсии.

long Akkerman (long m, long n) 
{
  if (m == 0) return n + 1;

  if (m > 0 && n == 0) return Akkerman(m - 1, 1);

  if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));

  return Akkerman(m,n);
}


Console.Write($"Введите число M: ");
long m = (long)Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите число N: ");
long n = (long)Convert.ToInt32(Console.ReadLine());

if (m >= 0 && n >= 0)
{
  Console.WriteLine($"Функция Аккермана с числами {m} и {n} = {Akkerman(m,n)}");
}
else
{
  Console.Write($"Какое-то из чисел меньше или равно 0. Введите, пожалуйста, два неотрицательных числа.");
}
*/