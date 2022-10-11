/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */


Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine());

string res = "";
for (int i = 1; i <= num; i++)
{
    Console.WriteLine(i);
    if (res == "")
    {
        res = res + Math.Pow(i, 3);
    }
    else
    {
        res = res + ", " + Math.Pow(i, 3);
    }
}

Console.WriteLine(res);