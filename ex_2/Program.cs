﻿/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
456->46
*/
int GetNumberFromRange(int start, int end)
{
    int number = new Random().Next(start, end + 1);
    return number;
}

int DeliteSecondDigit(int number)
{
    int digit3 = number%10;
    int digit1 = number/100;
    int result = digit1*10 + digit3;
    return result;
}


 int randomNumber = GetNumberFromRange(100, 999);
 int numberWithoutSecond = DeliteSecondDigit(randomNumber);
Console.WriteLine($"Число {randomNumber} без второй цифры {numberWithoutSecond}");