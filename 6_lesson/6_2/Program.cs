// Задача 2: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.

void Binary(int num)
{
    string Dec = "";
    while (num > 0)
    {
        Dec = num % 2 + Dec;
        num /= 2;
    }
    Console.WriteLine(Dec);
}

Binary(45);