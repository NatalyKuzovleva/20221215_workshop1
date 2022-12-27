// Задача 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (CheckMultiplicity(number))
{
    Console.WriteLine($"{number} -> да, число кратно одновременно 7 и 23");
}
else Console.WriteLine($"{number} -> нет, число не кратно одновременно 7 и 23");

bool CheckMultiplicity(int num)
{
    return (num % 7 == 0 && num % 23 == 0);
}

