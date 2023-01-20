/*
принимает число проверяет ли одновременно кратно оно 7 и 23
*/
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);

if (number % 7 ==0&&number % 23 ==0)
    {
        Console.WriteLine("Число кратно");
    }
else
{
    Console.WriteLine("Число не кратно");
}

