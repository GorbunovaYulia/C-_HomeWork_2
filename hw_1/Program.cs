/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трехзначное число");
int number = int.Parse(Console.ReadLine()!);

int digit3 = number%10;
int digit1 = number/100;
int result = (number-(digit1*100 + digit3))/10;
Console.WriteLine(result);