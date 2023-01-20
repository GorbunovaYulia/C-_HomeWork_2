/*
на вход 2 числа
и является ли второе число кратно первому
если не кратно, то выводить остаток от деления  
*/
Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 % number2 == 0)
    {
        Console.WriteLine("Число кратно");
    }
else
    {
        int ostatok = number1%number2;
        Console.WriteLine($"Число не кратно, остаток равен {ostatok}");
    }
    
