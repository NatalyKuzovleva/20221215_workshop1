// Задача 10. Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)
{
    int secondDigit = FindSecondDigit(number);
    Console.WriteLine($"Вторая цифра трехзначного числа -> {secondDigit}");
}
else Console.WriteLine("Введено не трехзначное число!");


int FindSecondDigit(int num)            // Метод для поиска 2й цифры трехзначного числа
{
    // int result = (num / 10) % 10;
    // return result;
    return (num / 10 % 10);
}