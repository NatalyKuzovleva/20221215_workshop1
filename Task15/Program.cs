// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день 
// выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите целое число от 1 до 7, затем нажмите ENTER:");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 7 || day < 1)
{
    Console.WriteLine("Неправильно введён день недели!");
}
else
{
    if (CheckHoliday(day))
    {
        Console.WriteLine($"{day} -> Да");
    }
    else
    {
        Console.WriteLine($"{day} -> Нет");
    }
}

bool CheckHoliday(int num)                  // Метод для проверки, является ли день выходным
{
    if (num == 6 || num == 7) return true;
    else return false;
}