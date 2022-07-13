// Задача 1: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.

double ProdNum(int a, int b)
{
    double c = 1;

    for (int i = 0; i < b; i++)
        c = c * a;
    return c;
}
Console.WriteLine(ProdNum(2, 4));
Console.WriteLine(ProdNum(4, 4));