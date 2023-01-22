// Задача 33. Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


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
    Console.WriteLine("]");
}


bool IsNumberExist(int num, int[] array)      // Метод определяет, присутствует ли заданное число в массиве 
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num) return true;
    }
    return false;
}
/*********************************************************************************/

int[] arr = CreateArrayRndInt(5, -10, 10);
PrintArray(arr);

Console.WriteLine($"Введите число, которое нужно найти в массиве:");
int findNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsNumberExist(findNumber, arr) 
? $"да, число {findNumber} присутствует в массиве" 
: $"нет, числа {findNumber} нет в массиве");

// if (IsNumberExist(findNumber, arr))
// {
//     Console.WriteLine($"да, число {findNumber} присутствует в массиве");
// }
// else Console.WriteLine($"нет, числа {findNumber} нет в массиве");
