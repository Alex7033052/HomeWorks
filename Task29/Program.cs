Console.WriteLine("Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
Console.WriteLine("Введите произвольное количество цифр через запятую");

var input = Console.ReadLine();
var numbers = input.Split(",").Select(p => int.Parse(p.Trim())).ToArray();
Console.WriteLine($"{input} -> " + String.Join(", ", numbers));

Console.WriteLine();
Console.WriteLine("Введите произвольное количество цифр через запятую");
input = Console.ReadLine();
numbers = input.Split(",").Select(p => int.Parse(p.Trim())).ToArray();
Console.WriteLine($"{input} -> " + String.Join(", ", numbers));
