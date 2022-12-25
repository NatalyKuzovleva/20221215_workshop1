// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int randomNumber = new Random().Next(100, 1000); // получаем случайное трехзначное число
Console.WriteLine($"Случайное трехзначное число в диапазоне 100...999 -> {randomNumber}");

int newDigit = DeleteMidDigit(randomNumber);
Console.WriteLine($"Новое число после удаления 2й цифры -> {newDigit}");
//Console.WriteLine($"{randomNumber} -> {newDigit}");

int DeleteMidDigit(int num)
{
    int res = (num / 100) * 10 + num % 10;
    return res;
}
