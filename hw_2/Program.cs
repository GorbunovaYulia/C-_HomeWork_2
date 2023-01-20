/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

float PositiveNumber = MathF.Sqrt(number*number);
if (PositiveNumber<100)
{
    Console.WriteLine("третьего числа нет");
}
else 
{
    Console.WriteLine();
}