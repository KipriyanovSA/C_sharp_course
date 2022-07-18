// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных. Значения элементов массива 0..9

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
        {
            Console.Write($" {arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] FillArray(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

int[] Vocabulary(int[,] arr)
{
    int[] array = new int[10];
    foreach (int item in arr) array[item]++;
    return array;
}

void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{i} {"встречается"} - {arr[i]} ");
    }
}

Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] arr_1 = FillArray(row, column);
Print(arr_1);
Console.WriteLine();
int[] arr_2 = Vocabulary(arr_1);
PrintArray(arr_2);