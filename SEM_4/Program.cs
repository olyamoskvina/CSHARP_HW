// // Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



// void FillArray(int[] numset)
// {
//     int Length = numset.Length;
//     int index = 0;
//     while (index < Length)
//     {
//         numset[index] = new Random().Next(1, 10);
//         index++;
//     }
// }

// void PrintArray(int[] numbers)
// {
//     int count = numbers.Length;
//     int pos = 0;
//     while (pos < count)
//     {
//         Console.WriteLine(numbers[pos]);
//         pos++;
//     }
// }

// int[] array = new int[8];

// FillArray(array);
// PrintArray(array);
// Console.WriteLine();



// Version-2

// int[] array = GetArray(8);
// Console.WriteLine($" [ {String.Join(",", array)} ] ");


// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(1,10);
//     }

//     return result;
// }


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// void RaiseToPow(int numberA, int numberB)
// {
//     if (numberA ==1)
//         Console.WriteLine("Число 1 в любой степени равно 1");
//     else if (numberA ==0)
//     {
//         Console.WriteLine("Ноль в любой степени равен нулю");
//     }
//     else Console.WriteLine($"Число {numberA} в степени {numberB} равно {Math.Pow(numberA, numberB)}");
// }

// Console.WriteLine("введите число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите число B: ");
// int numberB = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// RaiseToPow(numberA,numberB);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int GetSumNums(int num)
// {
//     int result = 0;
//     while (num > 0)
//     {
//         result = result + num % 10;
//         num = num / 10;
//     }
//     return result;
// }

// Console.WriteLine("введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine($"Сумма цифр в данном числе равна {GetSumNums(number)}");


