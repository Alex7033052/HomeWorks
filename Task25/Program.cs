Console.WriteLine("Задача 25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("Введите числа через запятую, например: 3,4");
var numbers = Console.ReadLine().Split(",").Select(p => int.Parse(p.Trim())).ToArray();
if (numbers.Length != 2)
{ 
    Console.WriteLine("Некорректный ввод. Выход");
    return;
}

var a = numbers[0];
var b = numbers[1];

Console.WriteLine($"{a},{b} -> " + Math.Pow(a, b));
