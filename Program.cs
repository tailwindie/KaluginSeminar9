/*
// Задача №25. Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)

int Powww(int a, int b)
{
  int i = 1 ;
  int res = 1 ;

  while( i <= b )
  {
    if( b==0 )
    {
      res  = 1;
      break; 
    }
    else
    {
      res *= a;
      i++ ;
    }
  }
  return res;
}

Console.WriteLine("Введите число: ");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите степень: ");
int b1 = Convert.ToInt32(Console.ReadLine());

int result = Powww(a1,b1);

Console.WriteLine($"{a1} в {b1} степени = {result}");
*/
//----------------------------------------------------------
/*
// Задача №27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Count(int a)
{
  int res = 0;
  while(a > 0)
  {
    res += (a % 10);
    a /= 10;
  }
  return res ;
}

  Console.Write("Введите число: ");
  int a1 = Convert.ToInt32(Console.ReadLine());


  if(a1 <=0)
  {
    Console.WriteLine($"Сумма цифр в вашем числе = 0.");
    Console.WriteLine($"Возможно, потому что вы просто написали 0 или отрицательное число.");
    Console.WriteLine($"Попробуйте заново. Впишите число больше нуля.");
  }
  else
  {
    int result = Count(a1);
    Console.WriteLine($"Сумма цифр в числе {a1} = {result}");
  }
*/
//----------------------------------------------------------
/*
// Задача №29. Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.

int [] GetArray(int n)
{
  int [] arr = new int[n];
  for (int i = 0; i < n; i++)
  {
    arr[i] = new Random().Next(1 , 100);
  }
  return arr;
}

void ShowArray(int [] arr)
{
  Console.Write($"Ваш массив: ");
  for( int i = 0; i < arr.Length; i++)
  {
    Console.Write($"{arr[i]} ");
  }
}
 
Console.Write("Введите размер массива: ");
int n1 = Convert.ToInt32(Console.ReadLine());

ShowArray(GetArray(n1));
*/