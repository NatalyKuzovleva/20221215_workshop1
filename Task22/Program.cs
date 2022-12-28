// Задача 22. Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 1)          // Возврат на ввод числа, если оно не натуральное
{
    Console.WriteLine($"Введено не натуральное число! Введите положительное целое число:");
    number = Convert.ToInt32(Console.ReadLine());
}

SquareNum(number);

void SquareNum(int num)
{
    int i = 1;
    while (i <= num)
    {
        Console.WriteLine($"{i, 3} {i * i, 7}"); // форматирование - задали длину строки 3 и 7 символов
        i++;
    }
}