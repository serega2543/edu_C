int num = new Random().Next(0, 100);
int a1 = num / 10;
int a2 = num % 10;
int max = a1;
Console.WriteLine($"{a1}, {a2}");
if (max < a2)
{
    max = a2;
}
Console.WriteLine($"Максимальная цифра в числе {num} -> {max}");

