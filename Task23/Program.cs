Console.WriteLine("Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
var number = int.Parse(Console.ReadLine());
if (number < 1)
{
    throw new Exception("Число должно быть больше 1");
}

var cubes = Enumerable.Range(1, number).Select(x => Math.Pow(x, 3));

Console.WriteLine($"{number} -> " + String.Join(", ", cubes));
