/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.Clear();
Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

double expResult = ExpNumber(numberA, numberB);
PrintResult(numberA, numberB, expResult);



double ExpNumber(int numA, int numB)
{
    double expNum = Math.Pow(numA, numB);
    return expNum;
}

void PrintResult(int numA, int numB, double numC)
{
    Console.WriteLine($"{numA}, {numB} -> {numC}");
}


