/*
// Задача №2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Число {a} больше, чем число {b}");
}
else if (b > a)
{
    Console.WriteLine($"Число {b} больше, чем число {a}");
}
else
{
    Console.WriteLine($"Числа {a} и {b} равны");
}
*/

//----------------------------------------------------------

/*
// Задача №4. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b >= max && b >= c)
{
    max = b;
}
else if (c >= max && c >= b)
{
    max = c;
}

Console.WriteLine($"Из чисел {a}, {b} и {c} наибольшее - {max}");
*/

//----------------------------------------------------------

/*
//Задача №6. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int tail = a % 2;

if (tail == 0)
{
    Console.WriteLine($"Число {a} - чётное");
}
else
{
    Console.WriteLine($"Число {a} - нечётное");
}
*/

//----------------------------------------------------------

/*
//Задача №8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int i = 0;

Console.Write($"От 1 до {N} чётные числа: ");

while (i <= N)
{
    Console.Write($"{i} ");
    i += 2;
}
*/