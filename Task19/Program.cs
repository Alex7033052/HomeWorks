Console.WriteLine("Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("Введите число");

var num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} -> " + (Tasks.IsPalindrome(num) ? "да" : "нет"));

num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} -> " + (Tasks.IsPalindrome(num) ? "да" : "нет"));

num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} -> " + (Tasks.IsPalindrome(num) ? "да" : "нет"));