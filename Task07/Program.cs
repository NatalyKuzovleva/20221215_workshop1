// Задача 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// Например:
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число:");
int num = Convert.ToInt32(Console.ReadLine());

// if (num > 99 && num < 1000)
if (num >= 100 && num <= 999) // проверка на трехзначность: число лежит в диапазоне [100 ... 999]
{
    // Console.WriteLine(num % 10);     // 456 % 10 = 6   % - вычисления остатка от деления
    // Console.WriteLine($"{num} -> {num % 10}");
    Console.WriteLine($"Последняя цифра числа {num} = {num % 10}");
}
else
{
    Console.WriteLine("Введено не трехзначное число!");
}
