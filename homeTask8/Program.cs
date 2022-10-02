// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
bool firstEntry = true;
for (int i = 1; i <= N; i++)
{
    
    int balanse = i % 2;
    if (balanse == 0)
    {
        if (firstEntry != true)
        {
            Console.Write(", ");
        }       
        Console.Write(i);
        firstEntry = false;
    }
}