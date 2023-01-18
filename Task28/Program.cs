// Задача 28. Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int number = EnterNumberRequest("Введите число: ");     //  Запрос на ввод числа от пользователя

if (number > 0)            // натуральное число - положительное целое, не ноль
{
    int factorial = ComputeFactorial(number);
    Console.WriteLine($"Произведение чисел от 1 до {number} = {factorial}");
}
else Console.WriteLine("Введено не натуральное число! Число должно быть больше 0!");


/**********************  МЕТОДЫ  **********************/

int EnterNumberRequest(string text)        // Метод на запрос ввода числа от пользователя
{
    Console.WriteLine(text);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int ComputeFactorial(int num)             // Метод для вычисления факториала (произведение чисел от 1 до N)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;            // Факториал числа N — это произведение натуральных чисел от 1 до N
    }
    return result;
}