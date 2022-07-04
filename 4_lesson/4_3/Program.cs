// Задача 2: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N

int MultNum(int num)
{
    int mult = 1;
    for (int i = 1; i <= num; i++)
        mult *= i;
    return mult;
}
Console.WriteLine(MultNum(4));
Console.WriteLine(MultNum(6));
