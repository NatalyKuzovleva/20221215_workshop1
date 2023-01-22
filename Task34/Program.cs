// Задача 34. Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


/**********************  МЕТОДЫ  **********************/

int[] CreateArrayRndInt(int size, int min, int max)     // Создание массива, заполненного случайными числами
{
    int[] array = new int[size];        // создаём массив
    Random rnd = new Random();          // создаём экземпляр класса Рандом
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


int AmountEvenNumbers(int[] array)      // Метод вычисляет количество чётных чисел в массиве 
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) amount++;
    }
    return amount;
}
/*********************************************************************************/

int[] arr = CreateArrayRndInt(5, 100, 999);
PrintArray(arr);

int amountEvenNum = AmountEvenNumbers(arr);

// Console.WriteLine($" -> {amountEvenNum}");
Console.WriteLine($"Количество чётных чисел в массиве равно {amountEvenNum}");