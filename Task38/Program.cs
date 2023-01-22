// Задача 38. Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


/**********************  МЕТОДЫ  **********************/

double[] CreateArrayRndDouble(int size, int min, int max)     // Создание массива, заполненного случайными вещественными числами
{
    double[] array = new double[size];      // создаём массив
    Random rnd = new Random();              // создаём экземпляр класса Рандом
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1, MidpointRounding.AwayFromZero);
        // Округляем до 1 знака после запятой
        // MidpointRounding.ToZero - Стратегия направленного округления к нулю
        // MidpointRounding.AwayFromZero - Стратегия округления до ближайшего числа, и когда число находится 
        // на полпути между двумя другими, оно округляется в сторону ближайшего числа, которое от нуля.
    }
    return array;
}


void PrintArray(double[] array)   // Вывод массива на печать в строку в формате [a1,a2,a3,a4,a5] 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + "; ");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}


double FindMinElement(double[] array)   // Поиск минимального элемента в массиве
{
    double minValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minValue) minValue = array[i];
    }
    return minValue;
}


double FindMaxElement(double[] array)   // Поиск максимального элемента в массиве
{
    double maxValue = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxValue) maxValue = array[i];
    }
    return maxValue;
}


// double FindDifference(double min, double max) // Поиск разницы двух вещественных чисел
// {
//     if (min < max) double result = max - min;
//     else result = min - max;
//     return result;
// }

/*********************************************************************************/

double[] arr = CreateArrayRndDouble(5, 0, 99);
PrintArray(arr);

double findMinElem = FindMinElement(arr);
Console.WriteLine($"Минимальный элемент массива равен {findMinElem}");

double findMaxElem = FindMaxElement(arr);
Console.WriteLine($"Максимальный элемент массива равен {findMaxElem}");

double findDifference = Math.Round(findMaxElem - findMinElem, 1, MidpointRounding.AwayFromZero);
Console.WriteLine($"Разница между максимальным и минимальным элементом массива равна {findDifference}");

//double findDifference = FindDifference(findMinElem, findMaxElem);

