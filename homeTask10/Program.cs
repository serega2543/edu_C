// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine());

int numStr = num.ToString().Length;
//Console.WriteLine(numStr);

if (numStr == 3)
{
//    int firstNum = num / 100;
    int secondNum = (num % 100) /10;
//    int thirdNum = num % 10;
//    Console.WriteLine("Первая цифра: " + firstNum);    
//    Console.WriteLine("Вторая цифра: " + secondNum);  
    Console.WriteLine(secondNum);  
//    Console.WriteLine("Третья цифра: " + thirdNum);  

}
else
{
    Console.WriteLine("Ошибка! Некорректное значение.");
}
