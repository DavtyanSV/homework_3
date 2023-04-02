// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


int ReadInt(string message)
{
    System.Console.WriteLine($"{message} -> ");
    int something = int.Parse(Console.ReadLine());
    return something;
}
int x1 = ReadInt("Введите x первой точки");
int y1 = ReadInt("Введите y первой точки");
int z1 = ReadInt("Введите z первой точки");

int x2 = ReadInt("Введите x второй точки");
int y2 = ReadInt("Введите y второй точки");
int z2 = ReadInt("Введите z второй точки");

double length = Math.Round(Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2)), 2); // Возводим внутри каждую разность в квадрот и позже из суммы разностей вычитаем корень. Также округляем вычисление до двух знаков после запятой

System.Console.WriteLine($"Расстояние между двумя точками в 3д пространстве = {length}");