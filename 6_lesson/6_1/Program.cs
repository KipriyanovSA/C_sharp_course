// Задача 1: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.

void Triangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
        Console.WriteLine("Возможен");
    else Console.WriteLine("Невозможен");

}

Triangle(3, 5, 3);