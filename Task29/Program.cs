// Задача 29. Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];
FillArray(array);
PrintArray(array);

/**********************  МЕТОДЫ  **********************/

void FillArray(int[] collection)            // Метод для заполнения элементов массива псевдослучайными числами
{
    for (int i = 0; i < collection.Length; i++)
    {
        collection[i] = new Random().Next(0, 100);
    }
}

// void PrintArr(int[] collection)           // Метод для вывода массива в терминал
// {
//        for (int i = 0; i < collection.Length; i++)
//     {
//         Console.Write($"{collection[i]} ");

//     }
// }

void PrintArray(int[] collection)           // Метод для вывода массива в терминал (на экран)
{
    Console.Write("[");
    for (int i = 0; i < collection.Length; i++)
    {
        if (i < collection.Length - 1) Console.Write(collection[i] + ", ");
        else Console.Write(collection[i]);
    }

    Console.Write("]");
}

