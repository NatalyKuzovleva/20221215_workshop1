// Задача 8. Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// Например:
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Если в условии указано ввести число N (с большой буквы N), то N - это натуральное число!!! 

// Вариант 1
// Console.WriteLine("Введите натуральное число:"); // натуральное число - положительное целое, не ноль
// int number = Convert.ToInt32(Console.ReadLine()); 

// if (number > 0)         // проверка, является ли введенное число натуральным
// {
//     int counter = 2;     // счётчик для цикла
//     while (counter <= number)
//     {
//         Console.Write(counter + " ");
//         counter = counter + 2;
//     }
// } 
// else
// {
//     Console.WriteLine("Число не является натуральным!");
// }


// Вариант 2
// Console.WriteLine("Введите натуральное число:"); // натуральное число - положительное целое, не ноль
// int number = Convert.ToInt32(Console.ReadLine());

// if (number > 0)                         // проверка, является ли введенное число натуральным
// {
//     if (number == 1)                    // особая строка вывода, в случае ввода 1
//     {
//         Console.WriteLine($"{number} -> В диапазоне чисел от 1 до 1 нет чётных чисел.");
//     }
//     else
//     {
//         int counter = 2;                    // счётчик для цикла
//         string res = "";                    // результат
//         while (counter <= number)
//         {
//             res = res + counter + " ";      // конкатенация (сложение) строк
//             counter = counter + 2;
//         }
//         Console.WriteLine($"{number} -> {res}");
//     }
// }
// else
// {
//     Console.WriteLine("Число не является натуральным!");
// }



// Вариант 3
Console.WriteLine("Введите натуральное число:"); // натуральное число - положительное целое, не ноль
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)                         // проверка, является ли введенное число натуральным
{
    Console.WriteLine("Число не является натуральным!");
}
else if (number == 1)                    // особая строка вывода, в случае ввода 1
{
    Console.WriteLine($"{number} -> В диапазоне чисел от 1 до 1 нет чётных чисел.");
}
else
{
    int counter = 2;                    // счётчик для цикла
    string res = "";                    // результат
    while (counter <= number)
    {
        res = res + counter + " ";      // конкатенация (сложение) строк
        counter = counter + 2;
    }
    Console.WriteLine($"{number} -> {res}");
}