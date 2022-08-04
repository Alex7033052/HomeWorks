Console.WriteLine("Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine("Введите сколько элементов массива нужно сгенерировать");

var input = Console.ReadLine();
var length = int.Parse(input.Trim());
var arr = new List<Int32>();

Random rd = new Random();
var evenCount = 0;
for (var i = 0; i < length; i++)
{
    var number = rd.Next(100, 999); 
    arr.Add(number);
    if (number % 2 == 0)
    {
        evenCount++;
    }
}


Console.WriteLine($"[{String.Join(", ", arr)}] -> " + evenCount);