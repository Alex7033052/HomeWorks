Console.WriteLine("Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");

Console.WriteLine("Введите число");
var number = Console.ReadLine();
var sum = number.ToCharArray().Select(p => int.Parse(p.ToString())).Aggregate(0, (acc, x) => acc + x);
Console.WriteLine($"{number} -> " + sum);

Console.WriteLine("Введите число");
number = Console.ReadLine();
sum = number.ToCharArray().Select(p => int.Parse(p.ToString())).Aggregate(0, (acc, x) => acc + x);
Console.WriteLine($"{number} -> " + sum);

Console.WriteLine("Введите число");
number = Console.ReadLine();
sum = number.ToCharArray().Select(p => int.Parse(p.ToString())).Aggregate(0, (acc, x) => acc + x);
Console.WriteLine($"{number} -> " + sum);