// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 3

int Numbers(int num)
{
    int count = 0;
    for (int i = 1; i <= num; i++)
    {
        Console.Write($"Число {i}: ");
        int n = int.Parse(Console.ReadLine());
        if (n > 0) count++;
    }
    return count;
}

Console.Write("Сколько чисел нужно ввести?: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество чисел больше 0: {Numbers(n)}");