// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine());


void PrintNumbers( int n)
{
    Console.Write($"{n} ");
    if (1 == n) return;
    PrintNumbers(n-1);
}
PrintNumbers(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите число  N: ");
int n = int.Parse(Console.ReadLine());


int GetSumNumbers(int m, int n, int sum = 0)   // int sum = 0 => Аргумент по умолчанию(если не передан в функцию, то по умолчанию - 0)
{
    if (m == n)
    {
        sum += m;
        return sum;
    }

    return GetSumNumbers(m + 1, n, sum + m);
}

int s = GetSumNumbers(m, n);
Console.WriteLine(s);




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
// m = 2, n = 3 -> A(m,n) = 29


int Akk(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m > 0) && (n == 0))
      return Akk(m - 1, 1);
    else
      return Akk(m - 1, Akk(m, n - 1));
}
    {
        Console.WriteLine(Akk(3, 2));
        
    }