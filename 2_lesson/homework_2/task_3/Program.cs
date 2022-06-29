void TakeNum(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        int num1 = 0;
        while (num > 999)
        {
            num = num / 10;
        }
        num1 = num % 10;
        Console.WriteLine(num1);
    }
}
TakeNum(762785);