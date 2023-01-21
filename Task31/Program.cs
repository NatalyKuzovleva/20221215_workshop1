// Задача 31. 
// 1. Задайте массив из 12 элементов, 
// 2. заполненный случайными числами из промежутка [-9, 9]. 
// 3. Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.



/**********************  МЕТОДЫ  **********************/

int[] CreateArrayRndInt(int size, int min, int max)     // Создание массива, заполненного случайными числами
// Метод создаёт массив
// на вход принимает int size - размер массива, 
// а также минимальное и максимальное число из диапазона случайных чисел
// Метод заполняет массив случайными числами
// int[] - метод возвращает массив
{
    int[] array = new int[size];    // создаём массив
    Random rnd = new Random();      // создать объект Рандом - экземпляр класса Рандом
    // необходимо сначала создать объект рандом, потом использовать Next
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
    Console.WriteLine("]");
}


int GetSumPositiveElem(int[] array)     // Метод находит сумму положительных элементов массива
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];
    }
    return sum;
}


int GetSumNegativeElem(int[] array)     // Метод находит сумму отрицательных элементов массива
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i];
    }
    return sum;
}

/*********************************************************************************/

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);

int sumPositive = GetSumPositiveElem(arr);
int sumNegative = GetSumNegativeElem(arr);

Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");
Console.WriteLine($"Сумма отрицательных чисел равна {sumNegative}");