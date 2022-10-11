// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int NumberProizved(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        //number = number/10;
        result = result * i;
   //     Console.Write(result);
    }
    return result;
}
Console.WriteLine(NumberProizved(number));
