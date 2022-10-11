/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите xA:");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите yA:");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите zA:");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите xB:");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите yB:");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите zB:");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Pow((Math.Pow(x2 - x1, 2) +
                         Math.Pow(y2 - y1, 2) +
                         Math.Pow(z2 - z1, 2) ), 0.5);

result = Math.Round(result, 2);

Console.WriteLine(result);                         