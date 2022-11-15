// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

Console.Clear();
Console.Write("Задайте значение M: ");
int m = int.Parse(Console.ReadLine())!;
Console.Write("Задайте значение N: ");
int n = int.Parse(Console.ReadLine())!;
int sum = 0;
if (m > n)
{
    SumNaturalNumbers(m, n, sum);
}
else
{
    SumNaturalNumbers(n, m, sum);
}


void SumNaturalNumbers(int max, int min, int sum)
{
    if (max - min >= 0)
    {
        sum = sum + max;
        max = max - 1;
        SumNaturalNumbers(max, min, sum);
    }
    else Console.Write(sum);
}