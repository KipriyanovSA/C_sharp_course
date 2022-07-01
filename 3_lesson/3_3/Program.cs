//Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

double Space(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
}
Space(7, -5, 1, -1);
Space(3, 6, 2, 1);
Console.WriteLine(Space(7, -5, 1, -1));
Console.WriteLine(Space(3, 6, 2, 1));