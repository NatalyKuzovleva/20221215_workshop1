// Задача 24. Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите натуральное число: ");    // запрос на ввод от пользователя
                                                    // натуральное число - положительное целое, не ноль
// int number = Convert.ToInt32(Console.ReadLine());
// Convert.ToInt32 - конвертирует не только строку, но и любой другой тип данных
int number = int.Parse(Console.ReadLine());  // конвертирует строку в int (целое число) - в выбранный тип данных

// Метод Parse() в качестве параметра принимает строку и возвращает объект текущего типа. Например:
// int a = int.Parse("10");
// double b = double.Parse("23,56");
// decimal c = decimal.Parse("12,45");
// byte d = byte.Parse("4");

if (number > 0)                         // Проверка на корректный ввод данных: является ли число натуральным?
{
    int sumNumbers = SumNumbers(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");
}
else Console.WriteLine("Введено некорректное число! Число должно быть больше 0!");


int SumNumbers(int num)              // Метод, который выдаёт сумму чисел от 1 до num
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}