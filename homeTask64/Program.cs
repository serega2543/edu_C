// Задача 64: Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "4, 2"
// N = 8 -> "8, 6, 4, 2,"

Console.Clear();
Console.Write("Задайте начальное значение: ");
int num = int.Parse(Console.ReadLine())!;
EvenFactorial(num);

void EvenFactorial(int num)
{
    if (num > 2)
    {
        if (num % 2 == 0)
        {
            Console.Write($"{num}, ");
        }
        num = num - 1;
        EvenFactorial(num);
    }
    else if (num == 2)
    {
        Console.Write(num);
    }
}