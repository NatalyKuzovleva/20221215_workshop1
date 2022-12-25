// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число и нажмите Enter:");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число и нажмите Enter:");
int number2 = Convert.ToInt32(Console.ReadLine());

// Вариант 1
// string CheckMultiplicity(int userNum1, int userNum2)    // Метод проверки на кратность
// {
//     if (userNum1 % userNum2 == 0)
//     {
//         return $"{userNum1}, {userNum2} -> кратно";
//     }
//     else
//     {
//         return $"{userNum1}, {userNum2} -> не кратно, остаток {userNum1 % userNum2}";
//     }
// }

// string result = CheckMultiplicity(number1, number2);
// Console.WriteLine(result);


// Вариант 2
bool CheckMultiplicity(int userNum1, int userNum2)
{
    if (userNum1 % userNum2 == 0) return true;
    else return false;
}

if (CheckMultiplicity(number1, number2))
{
    Console.WriteLine($"{number1}, {number2} -> кратно");
}
else 
{
    Console.WriteLine($"{number1}, {number2} -> не кратно, остаток {number1 % number2}");
}
