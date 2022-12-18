﻿// Задача 0. Напишите программу, которая на вход принимает число
// и выдаёт его квадрат (число умноженное на само себя).
// Например:
//  4 -> 16
// -3 ->  9
// -7 -> 49

// крутая команда CTRL+/ (CTRL+слеш) - комментирует/раскомментирует сразу несколько выделенных строк
// SHIFT + ALT + F - автоформатирование документа: расставляет автоматически пробелы и отступы;

Console.WriteLine("ПРОГРАММА ВЫЧИСЛЕНИЯ КВАДРАТА ЧИСЛА");
Console.WriteLine("Введите целое число, затем нажмите ENTER");
// Console.WriteLine("Введите целое число");
//Console - это объект, который содержит команды для работы с окном ввода/вывода
//в данном случае консоль у нас является терминалом.
// команда Write - всё выводит в одну строку;
// команда WriteLine - переводит курсор на следующую строку, т.е. в столбик будут выводится значения;

// по умолчанию используем тип данных int - целые числа, если явно не указано;
// тип double - это вещественные числа (дробные) с плавающей точкой;

// Начинаем с того, что нужно создать переменную целочисленного типа int number;
// С помощью команды Console.ReadLine() - получаем число, программа считывает то, что ввёл пользователь;
// int number = Console.ReadLine();
// НО! Console.ReadLine() возвращает строку (string)
// пользователь вводит текст, программа воспринимает как строку
// string str = Console.ReadLine();
// обязательна нужна конвертация строки в число, когда пользователь вводит данные
int number = Convert.ToInt32(Console.ReadLine());
// int - это 32-битное (4 байта) целое число, 
// диапазон принимаемых значений -(2 в степени 32) до +(2 в степени 32)
// Int32 - сколько места в памяти занимает переменная
//  byte 8 bit
//  short 16 bit
//  int 32 bit
//  long 64 bit
//  float num = 11553000000004.5746f; // любое вещественное число с плавающей точкой
//  double num_2 = 5.32423d; // любое вещественное число с плавающей точкой, еще большее
//  string word = "Hello! "; //любой символ, множество символов
//  char symbol = 'S'; //любой символ, число и т.п.
//  bool isHappy = true; // or false || логический оператор 
// (если тру, то выполняется одно, если фолс, то другое)

// или другой способ конвертации строки в число
// Например:
// string inputString = Console.ReadLine()!;
// int input = int.Parse(inputString);  // int.Parse - намного проще команда, принимает только строку
// Convert.ToInt32 - более универсальная команда, она конвертирует любой другой тип переменных, 
// не только строковый в число

int square = number * number; // создали другую переменную для записи в неё результата
Console.WriteLine($"Квадрат числа {number} = {square}");
// Интерполяция строк позволяет выводить значения переменных:
// перед кавычками ставим знак доллара $, 
// а переменные, которые хотим вывести, заключаем в фигурные скобки.


// Конечная программа без комментариев и пояснений:
// Console.WriteLine("Введите целое число");
// int number = Convert.ToInt32(Console.ReadLine());
// int square = number * number;
// Console.WriteLine($"Квадрат числа {number} = {square}");