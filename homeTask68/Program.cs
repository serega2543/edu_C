// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();
Console.Write("Задайте значение M: ");
int m = int.Parse(Console.ReadLine())!;
Console.Write("Задайте значение N: ");
int n = int.Parse(Console.ReadLine())!;

if (m > 0 && n > 0)
{
    int res = AckermanFunction(m, n);
    Console.Write($"m = {m}, n = {n} -> A(m, n) = {res}");
}
else
{
    Console.Write("Ошибка! Исходные данные не больше нуля.");
}


int AckermanFunction(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
    if ((n != 0) && (m == 0))
        return AckermanFunction(n - 1, 1);
    else
        return AckermanFunction(n - 1, AckermanFunction(n, m - 1));
}