/*3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница*/

Console.WriteLine("Введите номер дня недели:");
int numberWeek = int.Parse(Console.ReadLine());

string strday = DateTime.DayOfWeek(numberWeek); 
Console.WriteLine(strday);

