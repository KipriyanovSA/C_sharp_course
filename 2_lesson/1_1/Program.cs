﻿// принимает на вход трёхзначное число и на выходе
// показывает последнюю цифру этого числа.

int TakeNum(int num)
{
    return num % 10;
}
Console.WriteLine(TakeNum(678));
