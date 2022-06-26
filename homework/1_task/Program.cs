int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int max = a;
int min = b;
if (a < b)
{
    max = b;
    min = a;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);