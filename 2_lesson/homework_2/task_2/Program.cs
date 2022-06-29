void FirstNum(int num)
{
    int num1 = num / 100;
    int num2 = num % 10;
    Console.WriteLine($"{num1}{num2}");
}
int SecondNum = new Random().Next(100, 999);
Console.WriteLine(SecondNum);
FirstNum(SecondNum);