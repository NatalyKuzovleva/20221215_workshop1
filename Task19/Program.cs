// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом. Выполнить с помощью 
// числовых операций (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 10000 || number > 99999)       // Проверка на пятизначность
{
    Console.WriteLine("Введено не пятизначное число. Проверьте введенные данные!");
}
else
{
    if (CheckPalindrome(number)) Console.WriteLine($"{number} -> да, число является палиндромом");
    else Console.WriteLine($"{number} -> нет, число не является палиндромом");
}

    bool CheckPalindrome(int num)
    {
        return (num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 10);

        // if ((num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 10)) return true;
        // else return false;
    }