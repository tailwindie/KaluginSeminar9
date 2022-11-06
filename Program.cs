/*
// Задача №19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome(int num)
{
  int num1 = num;
  int num2 = 0;

while (num > 0)
{
    num2 = (num % 10) + (num2 * 10 );
    num /= 10;
}

if (num2 != num1)
{
  Console.Write($"{num1} - не палиндром! Вот оно наоборот: {num2}.");  
}
else
{
  Console.Write($"{num1} - это палиндром!. Вот оно наоборот: {num2}");
}
};

while (true)
{
  Console.Write("Введите пятизначное число: ");
  int num = Convert.ToInt32(Console.ReadLine() );

  if (num>=10000 && num<=99999)
  {
    Palindrome(num);
    break;
  }
  else
  {
    Console.Write("Вы ввели не пятизначное число!") ;
  };
}
*/
//----------------------------------------------------------
/*
// Задача №21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Coords(int xa, int ya, int za, int xb, int yb, int zb)
{
 double abz = Math.Sqrt( ((xb-xa) * (xb-xa)) + ((yb-ya) * (yb-ya)) + ((zb-za) * (zb-za)) );
 return abz;
}

Console.Write("Введите X координату точки A: ");
int xa1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки A: ");
int ya1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату точки A: ");
int za1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите X координату точки B: ");
int xb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y координату точки B: ");
int yb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z координату точки B: ");
int zb1 = Convert.ToInt32(Console.ReadLine());



double distance = Coords(xa1, ya1, za1, xb1, yb1, zb1);

Console.Write($"Расстояние между точками A ({xa1}, {ya1}, {za1}) и B ({xb1}, {yb1}, {zb1}) = {distance} ");
*/
//----------------------------------------------------------
/*
// Задача №23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int N)
{
    if (N != 0)
    {
        int a = 0;
        int i = 1;
        while (i <= N)
        {
            a = i*i*i;
            Console.Write($"{a} ");
            i++;
        } 
    }
    else
    {
        Console.Write("Умный ход! Вот ваша таблица: 0");
    }
};

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Cube(N);
*/