// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

Console.Clear();

int[,] array = GetArray(new Random().Next(1, 10), new Random().Next(1, 10), 0, 100);
PrintArray(array);
Console.WriteLine();

Console.Write("Введите номер строки: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int columns = int.Parse(Console.ReadLine());

Console.WriteLine();
PrintResult(rows, columns, array);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintResult(int rows, int colums, int[,] arr)
{
    if (rows <= arr.GetLength(0) && columns <= arr.GetLength(1))
    {
        int pos = arr[rows-1, columns-1]; 
        Console.WriteLine($"Число с адресом [{rows}, {columns}] = {pos}");
    }
    else
    {
        Console.WriteLine($"Число с адресом [{rows}, {columns}] не существует");
    }
}