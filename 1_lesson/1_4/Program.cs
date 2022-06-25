int n = int.Parse(Console.ReadLine());
int x = -n;

while (x < n + 1)
{
    Console.WriteLine(x);
    x = x += 1;
}
