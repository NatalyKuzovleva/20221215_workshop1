// Задача 36. Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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
    Console.Write("]");
}


int SumOddElems(int[] array)      // Метод вычисляет сумму элементов, стоящих на нечётных позициях 
{                                 // [3, 7, 23, 12] -> 19
                                  //  0  1   2   3
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
/*********************************************************************************/

int[] arr = CreateArrayRndInt(10, -10, 10);
PrintArray(arr);

int sumOddElems = SumOddElems(arr);
Console.WriteLine($" -> Сумма элементов на нечётных позициях равна {sumOddElems}");