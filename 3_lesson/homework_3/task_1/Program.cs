// Задача 1: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да

void Pal(int num)
{
    int i = 0;
    string numbers = num.ToString();
    int size = numbers.Length - 1;
    string flag = "Да";

    while (i < size / 2)
    {
        if (numbers[i] != numbers[size - i])
        {
            flag = "Нет";
            break;
        }
        i++;
    }
    Console.WriteLine($"{num} -> {flag}");
}

Pal(14212);
Pal(123454321);


