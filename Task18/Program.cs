// Задача 18. Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти (от 1 до 4):");
int range = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Range(range));

string Range(int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return "Нет такой четверти!";
}