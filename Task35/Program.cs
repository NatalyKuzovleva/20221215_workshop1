// Задача 35. Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123.

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


/**********************  МЕТОДЫ  **********************/

int[] CreateArrayRndInt(int size, int min, int max)     // Создание массива, заполненного случайными числами
{
    int[] array = new int[size];    // создаём массив
    Random rnd = new Random();      // создаём экземпляр класса Рандом
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}


void PrintArray(int[] array)   // Вывод массива на печать в строку в формате [a1,a2,a3,a4,a5] 
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}


int CountElements(int[] array, int min, int max)    // Метод, подсчитывающий количество элементов массива, 
                                                    // значения которых лежат в отрезке [min, max].
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max) result++;
    }
    return result;
}

/*********************************************************************************/

int[] arr = CreateArrayRndInt(10, 0, 125);

// Console.WriteLine($"Введите минимальное значение границы отрезка:");
// int minValueSegment = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Введите максимальное значение границы отрезка:");
// int maxValueSegment = Convert.ToInt32(Console.ReadLine());

int minValueSegment = 10;
int maxValueSegment = 99;

PrintArray(arr);
int countElem = CountElements(arr, minValueSegment, maxValueSegment);
Console.WriteLine($" -> {countElem}");

// if (countElem == 1 || countElem == 21 || countElem == 31 || countElem == 41 || countElem == 51 ||
//     countElem == 61 || countElem == 71 || countElem == 81 || countElem == 91)
// {
//     Console.WriteLine($" -> {countElem} элемент лежит в отрезке [{minValueSegment}, {maxValueSegment}]");
// }
// else if (countElem == 2 || countElem == 3 || countElem == 4 ||
//          countElem == 22 || countElem == 23 || countElem == 24 ||
//          countElem == 32 || countElem == 33 || countElem == 34 ||
//          countElem == 42 || countElem == 43 || countElem == 44 ||
//          countElem == 52 || countElem == 53 || countElem == 54 ||
//          countElem == 62 || countElem == 63 || countElem == 64 ||
//          countElem == 72 || countElem == 73 || countElem == 74 ||
//          countElem == 82 || countElem == 83 || countElem == 84 ||
//          countElem == 92 || countElem == 93 || countElem == 94)
// {
//     Console.WriteLine($" -> {countElem} элемента лежит в отрезке [{minValueSegment}, {maxValueSegment}]");
// }
// else Console.WriteLine($" -> {countElem} элементов лежит в отрезке [{minValueSegment}, {maxValueSegment}]");

