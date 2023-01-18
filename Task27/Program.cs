// Задача 27. Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


int number = EnterNumberRequest("Введите число: ");     //  Запрос на ввод числа от пользователя
int sum = DigitsSum(number);

Console.WriteLine($"Сумма цифр в числе {number} = {sum}");

/**********************  МЕТОДЫ  **********************/

int EnterNumberRequest(string text)           // Метод на запрос ввода числа от пользователя
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int DigitsSum(int num)                      // Метод для вычисления суммы цифр в числе
{
    num = Math.Abs(num);    // модуль числа
    int digitSum = 0;
    while (num != 0)
    {
        digitSum = digitSum + num % 10;
        num = num / 10;
    }
    return digitSum;
}