﻿// Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.WriteLine("Введите три числа, подтверждая ввод каждого числа ENTER:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;
if (number2 > max) max = number2;
else if (number3 > max) max = number3;

Console.WriteLine($"{number1}, {number2}, {number3} -> {max}");