// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

int minValue = 0;
int maxValue = 1;

int[,] array = GetArray(rows, columns, minValue, maxValue);
PrinTtwoDimensionalArray(array);
SumOfLines(array);

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

void SumOfLines(int[,] inArray)
{
    int minValue = 0;
    string line = "";
    int count = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
            sum += inArray[i, j];
        if (i == 0) { minValue = sum; count = 1; }
        if (sum < minValue)
        {
            minValue = sum;
            line = (i+1).ToString();
            count = 1;
        }
        else if (sum == minValue){
            if (line==""){
                line = (i+1).ToString();
            }
            else{
                line = line + ", "+ (i+1).ToString();
            }
            count++;
        }
    }
    if (count == 1){
        Console.WriteLine($"{line} строка");
    }
    else{
        Console.WriteLine($"{line} строки");
    }
}