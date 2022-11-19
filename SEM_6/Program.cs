// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

Console.Clear();

int[] CreateArray()
{
    Console.WriteLine("Введите количество элементов массива");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int[] myArray = CreateArray();

Console.WriteLine($" [ {String.Join(", ", myArray)} ] ");


int GetPosNumbers(int[] myArray)
{
    int count = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] > 0)
        {
            count++;
        }
    }
    return count;

}

    Console.WriteLine($"Количество положительных чисел : {GetPosNumbers(myArray)}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

Console.Write("введите через пробел b1, k1, b2, k2: ");

string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(array[0]);
double k1 = double.Parse(array[1]);
double b2 = double.Parse(array[2]);
double k2 = double.Parse(array[3]);

Console.WriteLine(String.Join(" ", Point(b1, k1, b2, k2)));

double[] Point(double B1, double K1, double B2, double K2)
{
    double[] result = new double[2];
    result[0] = (B2 - B1) / (K1 - K2);
    result[1] = K1 * result[0] + B1;
    return result;
}


