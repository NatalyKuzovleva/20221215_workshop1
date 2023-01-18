// Задача 25. Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int numberA = EnterNumberRequest();               //  Запрос на ввод 1-ого числа от пользователя
int numberB = EnterNumberRequest();               //  Запрос на ввод 2-ого числа от пользователя


// Простой вариант -> возводим число A в натуральную степень B

// if (numberB > 0)
// {
//     int power = RaisingPositivePower(numberA, numberB);
//     Console.WriteLine($"Число {numberA} в степени {numberB} = {power}");
// }
// else Console.WriteLine("Введено некорректное значение! Второе число (степень) должна быть > 0!");



// Универсальный вариант -> возводим число A в любую степень B, где A и B - целые числа
if (numberB > 0)
{
    int power = RaisingPositivePower(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени {numberB} = {power}");
}
else if (numberB < 0)
{
    double power = RaisingNegativePower(numberA, numberB);
    power = Math.Round(power, 5, MidpointRounding.AwayFromZero); // Округляем до 5 знаков после запятой
                                                                 // MidpointRounding.ToZero - Стратегия направленного округления к нулю
                                                                 // MidpointRounding.AwayFromZero - Стратегия округления до ближайшего числа, и когда число находится 
                                                                 // на полпути между двумя другими, оно округляется в сторону ближайшего числа, которое от нуля.

    Console.WriteLine($"Число {numberA} в степени {numberB} = {power}");
}
else   // (numberB = 0)
{
    Console.WriteLine($"Число {numberA} в степени {numberB} = 1");
}


/**********************  МЕТОДЫ  **********************/

int EnterNumberRequest()                             // Метод на запрос ввода числа от пользователя
{
    Console.WriteLine("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int RaisingPositivePower(int num1, int num2)             // Метод возведения числа num1 в положительную степень num2
{
    int result = 1;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return result;
}

double RaisingNegativePower(int num1, int num2)  // Метод возведения числа num1 в отрицательную степень num2
{
    double result = 1;
    num2 = -1 * num2;
    for (int i = 1; i <= num2; i++)
    {
        result = result * num1;
    }
    return 1 / result;
}