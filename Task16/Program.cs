// Задача 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите два числа:");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckSQR(number1, number2)
? $"{number1}, {number2} -> да"
: $"{number1}, {number2} -> нет");
// if (CheckSQR(number1, number2)) Console.WriteLine($"{number1}, {number2} -> да");
// else Console.WriteLine($"{number1}, {number2} -> нет");

bool CheckSQR(int num1, int num2)
{
   // return num1 * num1 == num2 || num2 * num2 == num1;
    return num1 / num2 == num2 || num2 / num1 == num1;
}