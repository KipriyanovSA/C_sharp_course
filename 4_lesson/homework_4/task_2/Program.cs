// Задача 2: Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.

int Total(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
Console.WriteLine(Total(2366));