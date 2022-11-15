// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//(посмотрите как реализуется произведение матриц, там не просто перемножение элемент на элемент)
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();


int minValue = 0;
int maxValue = 10;

Console.WriteLine("Первая матрица:");
int[,] array1 = GetArray(minValue, maxValue);
PrinTtwoDimensionalArray(array1);
Console.WriteLine("Вторая матрица:");
int[,] array2 = GetArray(minValue, maxValue);
PrinTtwoDimensionalArray(array2);
Console.WriteLine();
Console.WriteLine("Результирующая матрица:");

int[,] array3 = DivArray(array1, array2);
PrinTtwoDimensionalArray(array2);


int[,] GetArray(int minValue, int maxValue)
{
    Console.Write("Введите количество строк массива: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов массива: ");
    int columns = int.Parse(Console.ReadLine());
    
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrinTtwoDimensionalArray(int[,] inArray)
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



int[,] DivArray(int[,] arr1, int[,] arr2)
{
    var arr3 = new int[arr1.GetLength(0), arr2.GetLength(1)];
    if (arr1.GetLength(1) == arr2.GetLength(0))
    {
        for (int i = 0; i < arr3.GetLength(0); i++)
        {
            for (int j = 0; j < arr3.GetLength(1); j++)
            {
                arr3[i, j] = 0;
                for (int n = 0; n < arr1.GetLength(1); n++)
                {
                    arr3[i, j] += arr1[i, n] * arr2[n, j];
                }
            }
        }
    }
    return arr3;
}
