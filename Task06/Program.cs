﻿// Задача 6. Напишите программу, которая на вход принимает число 
// и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Например:
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите целое число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)   // Четное число — это целое число, делящееся без остатка на 2
{
    // Console.WriteLine($"{num} -> да");
    Console.WriteLine($"Число {num} -> чётное");
} 
else
{
    // Console.WriteLine($"{num} -> нет");
    Console.WriteLine($"Число {num} -> не является чётным");
}