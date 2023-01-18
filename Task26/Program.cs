// Задача 26. Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int number = EnterNumberRequest("Введите число: ");     //  Запрос на ввод числа от пользователя
int amount = DigitsAmount(number);

Console.WriteLine($"Количество цифр в числе {number} = {amount}");


/**********************  МЕТОДЫ  **********************/

int EnterNumberRequest(string text)           // Метод на запрос ввода числа от пользователя
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int DigitsAmount(int num)                   // Метод для вычисления количества цифр в числе
{
    int count = 0;
    if (num == 0) return count = 1;

    while (num != 0)    //!=0 (пока не 0) на тот случай если пользователь ввел отрицательное значение
    {
        num = num / 10;
        count++;
    }
    return count;
}


// int DigitsAmount(int num)                   // Метод для вычисления количества цифр в числе
// {
//     // if (num < 0) num = (-1) * num;
//     num = Math.Abs(num);       // модуль числа
//     int count = 1;
//     while (num > 9)
//     {
//         num = num / 10;
//         count++;
//     }
//     return count;
// }