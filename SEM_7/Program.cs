// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows=int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=int.Parse(Console.ReadLine());

double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

double[,] GetArray(int m, int n, int min, int max)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble()*(max-min);
        }
    }
    return result;
}
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]:f2} ");
        }
        Console.WriteLine();
    }
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);

int[,] array = GetArray(rows, columns, 1, 9);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите позицию элемента в массиве: ");
int position = int.Parse(Console.ReadLine());
int mult = rows * columns;

if (position == mult) Console.WriteLine($"Число на заданной позиции : {array[rows - 1, columns - 1]}");
else if (position == 1) Console.WriteLine($"Число на заданной позиции : {array[0, 0]}");

else if (position < mult)
{
    int x = position / columns;
    int y = position % columns - 1;
    if(position%columns==0)
    {
        x--;
    }
    if (y == -1)
    {
        y = columns - 1;
    }

// Console.WriteLine($"{x} {y}");    для отладки
    Console.WriteLine($"Число на заданной позиции : {array[x, y]}");

}
else Console.WriteLine("Элемента с заданной позицией в массиве не существует");







// Task 50. Version2

Console.Clear();

int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);

int[,] array = GetArray(rows, columns, 1, 9);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите позиции элемента в массиве , без пробела(строка и столбец)");
int xy = int.Parse(Console.ReadLine());

int x = xy / 10;
int y = xy % 10;

if (x < rows && y < columns)
{
    Console.WriteLine($"{array[x , y ]}");
}
else Console.WriteLine("Данного элемента нет в массиве.");




// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();

int rows = new Random().Next(2, 10);
int columns = new Random().Next(2, 10);

int[,] array = GetArray(rows, columns, 1, 9);
PrintArray(array);

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}



void Average(int[,] array)
{
    Console.WriteLine();
    Console.Write("Среднее арифметическое столбцов в массиве: ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        double avg = sum / array.GetLength(0);
        Console.Write($"{avg:f1}; ");
    }
}

Average(array);