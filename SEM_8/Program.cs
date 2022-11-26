// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Clear();

// int rows = new Random().Next(2, 10);
// int columns = new Random().Next(2, 10);

// int[,] array = GetArray(rows, columns, 1, 9);
// PrintArray(array);


// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// Console.WriteLine();


// void SortRows(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }
// Console.WriteLine("changed array: ");
// SortRows(array);
// PrintArray(array);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Clear();

// int rows = new Random().Next(2, 7);
// int columns = new Random().Next(2, 10);

// int[,] array = GetArray(rows, columns, 1, 9);
// PrintArray(array);

// int[,] GetArray(int m, int n, int min, int max)

// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }


// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine();


// void MinSumNums(int[,] array)
// {
//     int minSum = columns * 9;      // сумма элементов строки ( по завершению функции будет минимальной)
//     int minSumRow = 0;          // # строки с минимальной суммой элементов
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         if (sum < minSum)
//         {
//             minSum = sum;
//             minSumRow = i;
//         }
//         // Console.WriteLine($"Сумма элементов в {i + 1} строке: {sum}");
//     }
//     Console.WriteLine();
//     Console.WriteLine($"Наименьшая сумма элементов находится в {minSumRow + 1} строке");
// }
// MinSumNums(array);




// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// Console.Clear();

// Console.Write("Введите количество строк первой матрицы: ");
// int rowsMatrixA = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов первой матрицы: ");
// int columnsMatrixA = int.Parse(Console.ReadLine());

// Console.Write("Введите количество строк второй матрицы: ");
// int rowsMatrixB = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов второй матрицы: ");
// int columnsMatrixB = int.Parse(Console.ReadLine());

// if (columnsMatrixA != rowsMatrixB)
// {
//     Console.WriteLine("Произведение данных матриц невозможно");
// }

// int[,] matrixA = GetArray(rowsMatrixA, columnsMatrixA, 0, 10);
// int[,] matrixB = GetArray(rowsMatrixB, columnsMatrixB, 0, 10);

// PrintArray(matrixA);
// Console.WriteLine();
// PrintArray(matrixB);
// Console.WriteLine();



// int[,] GetArray(int m, int n, int min, int max)

// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] inArray)
// {
//     for (int i = 0; i < inArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inArray.GetLength(1); j++)
//         {
//             Console.Write($"{inArray[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] MatrixMultiplication(int[,] arrayA, int[,] arrayB)
// {
//     int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
//     for (int i = 0; i < arrayA.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayA.GetLength(1); j++)
//         {
//             for (int l = 0; l < arrayA.GetLength(1); l++)
//             {
//                 arrayC[i, j] += arrayA[i, l] * arrayB[l, j];
//             }
//         }
//     }
//     return arrayC;
// }

// Console.WriteLine("Произведение матриц: ");
// PrintArray(MatrixMultiplication(matrixA, matrixB));


// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.Clear();
// Console.WriteLine("Введите через пробел размеры массива");
// string[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
// int[,,] array = GetArray(new int[] { int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2]) } , 10, 99);

// PrintArray(array);

// int[,,] GetArray(int[] size, int min, int max)
// {
//     int[,,] result = new int[size[0], size[1], size[2]];

//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             int k = 0;
//             while (k < result.GetLength(2))
//             {
//                 int num = new Random().Next(min, max + 1);
//                 if (FindNum(result, num)) continue;
//                 result[i, j, k] = num;
//                 k++;
//             }
//         }
//     }
//     return result;
// }

// bool FindNum(int[,,] array, int number)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 if (array[i, j, k] == number) return true;
//             }
//         }
//     }
//     return false;
// }



// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]} ({i},{j},{k})   ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Console.Clear();


// int n = 4;
// int[,] squareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= squareMatrix.GetLength(0) * squareMatrix.GetLength(1))    //кол-во эл-в в матрице
// {
//   squareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < squareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= squareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > squareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// PrintArray(squareMatrix);

// void PrintArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }