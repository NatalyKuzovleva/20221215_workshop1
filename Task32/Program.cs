// Задача 32. Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


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


void InverseArray(int[] array)      // Метод заменяет положительные элементы массива на соответствующие 
{                                   // отрицательные, и наоборот. Ничего не возвращает
    for (int i = 0; i < array.Length; i++)  // Возвращать массив не нужно, массив передаётся по ссылке
    {                                       // т.е. мы не создаём новый массив, чтобы вернуть его из метода
        array[i] = -array[i];               // мы меняем исходный массив
    }
}
/*********************************************************************************/

int[] arr = CreateArrayRndInt(12, -9, 9);
PrintArray(arr);
InverseArray(arr);
PrintArray(arr);