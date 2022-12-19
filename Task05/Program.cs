﻿// Задача 5. Напишите программу, которая на вход принимает
// одно число (N), а на выходе показывает все целые
// числа в промежутке от -N до N.
// Например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// Если в условии указано ввести число N (с большой буквы N), то N - это натуральное число!!! 

// Вариант 1
// Console.WriteLine("Введите натуральное число:"); // натуральное число - положительное целое, не ноль
// int number = Convert.ToInt32(Console.ReadLine()); // все переменные называем с маленькой буквы
// if (number > 0) // проверяем правильность введённого числа - натуральное ли оно?
// {
//     int counter = -number; // счётчик для цикла

//     while (counter <= number)
//     {
//         Console.Write(counter + " "); // конкатенация (сложение) строк
//         counter++;  //инкремент - операция, увеличивающая переменную на 1;
//     }
// }
// else
// {
//     Console.WriteLine("Некорректные данные!");
// }



// Вариант 2
Console.WriteLine("Введите натуральное число:"); // натуральное число - положительное целое, не ноль
int number = Convert.ToInt32(Console.ReadLine()); // все переменные называем с маленькой буквы
if (number > 0) // проверяем правильность введённого числа - натуральное ли оно?
{
    int counter = -number; // счётчик для цикла
    string res = "";        //результат
    while (counter <= number)
    {
       res = res + counter + "  "; // конкатенация (сложение) строк
       counter++;  //инкремент - операция, увеличивающая переменную на 1;
    }
    Console.WriteLine($"{number} -> {res}");
}
else
{
    Console.WriteLine("Некорректные данные!");
}