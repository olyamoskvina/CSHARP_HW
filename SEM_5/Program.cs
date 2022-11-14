//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.Clear();

// int[] CreateRandomArray(int N, int start, int end)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }


// Console.WriteLine("Введите количество элементов массива: ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите диапaзон массива: ");

// int minValue = int.Parse(Console.ReadLine());
// int maxValue = int.Parse(Console.ReadLine());

// int[] myArray = CreateRandomArray(N, minValue, maxValue);



// int count = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] % 2 == 0)
//     count++;
// }

// Console.WriteLine($" [ {String.Join(", ", myArray)} ] ");

// Console.WriteLine($"Количество четных элементов в массиве {count}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray(int N, int minValue, int maxValue)
// {
//     int[] RandomArray = new int[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(minValue, maxValue++);
//     }
//     return RandomArray;
// }
// Console.WriteLine("Введите количество элементов массива: ");
// int N = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(N,-1000,1000);
// Console.WriteLine($" [ {String.Join(", ", myArray)} ] ");

// int sum = 0;

// for (int i = 1; i<myArray.Length; i += 2)
// {
//     sum += myArray[i];
// }
// Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях - {sum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// Console.Clear();


// double[] CreateRandomDoubleArray(int N, int minValue, int maxValue)
// {
//     double[] RandomArray = new double[N];
//     for (int i = 0; i < N; i++)
//     {
//         RandomArray[i] = new Random().Next(minValue, maxValue++)/10.0;
//     }
//     return RandomArray;
// }

// Console.WriteLine("Введите количество элементов массива: ");
// int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// double[] myArray = CreateRandomDoubleArray(N, -1000, 1000);
// Console.WriteLine($" [ {String.Join("  " , myArray)} ] ");


// double max = myArray[0];
// double min = myArray[0];

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > max)
//     {
//         max = myArray[i];

//     }
//     else if (myArray[i] < min)
//         min = myArray[i];
// }

// double diff = max - min;
// Console.WriteLine($"разница между максимальным и минимальным элементом массива : {Math.Round(diff,3)}");






