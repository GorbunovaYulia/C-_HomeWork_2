/*
принимает 2 числа, проверяет является ли одно число квадратом другого
*/
Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число");
int number2 = int.Parse(Console.ReadLine()!);

if (number1==number2*number2||number2==number1*number1)
{
    Console.WriteLine("Да");
}
else
{
     Console.WriteLine("Нет");
}