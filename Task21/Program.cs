// Задача 21. Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D 
// пространстве.

// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int x1 = InsertPosition("Введите координату X первой точки:");
int y1 = InsertPosition("Введите координату Y первой точки:");
int z1 = InsertPosition("Введите координату Z первой точки:");

int x2 = InsertPosition("Введите координату X второй точки:");
int y2 = InsertPosition("Введите координату Y второй точки:");
int z2 = InsertPosition("Введите координату Z второй точки:");

double result = LenghtLine(x1, y1, z1, x2, y2, z2);
double resRound = Math.Round(result, 2, MidpointRounding.ToZero); // Округляем до 2х знаков после запятой
// MidpointRounding.ToZero - Стратегия направленного округления к нулю

Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}) -> Расстояние между двумя точками равно {resRound}");

int InsertPosition(string text)
// Метод будет вызывать текст на запрос координаты, конвертировать введённую координату в число
{
    Console.WriteLine(text);
    int pos = Convert.ToInt32(Console.ReadLine());
    return pos;
}

double LenghtLine(int xpos1, int ypos1, int zpos1, int xpos2, int ypos2, int zpos2)
{
    int temp = (xpos1 - xpos2) * (xpos1 - xpos2) + (ypos1 - ypos2) * (ypos1 - ypos2) + (zpos1 - zpos2) * (zpos1 - zpos2);
    return Math.Sqrt(temp);         // возвращаем квадратный корень из числа = расстояние между точками
}