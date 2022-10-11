// Задача 24: Напишите программу, которая принимает на вход число (А) 
// и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");
int num1= int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {GetSumNums(num1)}");
int num2 = int.Parse(Console.ReadLine());
int result = GetSumNums(num2);
Console.WriteLine($"Сумма цифр = {result+num1}");


int GetSumNums(int number)
{
    int sum = 0;
    while(number>0)
    {
        sum += number;
        number--;
    }
    return sum;
}