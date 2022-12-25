// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число и нажмите Enter:");
int number = Convert.ToInt32(Console.ReadLine());

// int CountDigits(int num)    // Метод, который вычисляет скольки-значное число
// {
//     if (num < 0)        // Если число отрицательное - делаем его положительным
//     {
//         num = num * (-1);
//     }

//     int counter = 1;
//     while (num > 9)
//     {
//         num = num / 10;
//         counter++;
//     }
//     return counter;
// }

// int quantity = CountDigits(number);
// if (quantity == 1)
// {
//     Console.WriteLine($"Число состоит из {quantity} знака.");
// }
// else Console.WriteLine($"Число состоит из {quantity} знаков.");
// //Console.WriteLine($"Число {quantity}-значное.");

if (number > -100 && number < 100)              // Проверка, есть ли 3я цифра
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}

else
{
    int thirdDigit = FindThirdDigit(number);
    Console.WriteLine($"Третья цифра числа {number} -> {thirdDigit}");
}

int FindThirdDigit(int num)             // Метод по поиску 3-й цифры в числе
{
    if (num < 0)   num = num * (-1);     // Если число отрицательное - делаем его положительным

    while (num > 1000)
    {
        num = num / 10;
    }

    int result = num % 10;
    return result;
}
