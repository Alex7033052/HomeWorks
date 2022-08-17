Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");

Random rd = new Random();

int[][] GenerateArray()
{
    Console.WriteLine("Сгенерирован массив");
    var rows = 4;
    var columns = 5;
    var arrays = new int[rows][];
    for (var i = 0; i < rows; i++)
    {
        var array = arrays[i] = new int[columns];
        for (var j = 0; j < columns; j++)
        {
            array[j] = rd.Next(0, 30);
        }
        Console.WriteLine(String.Join(", ", array));
    }

    return arrays;
}

var arrays = GenerateArray();

Console.WriteLine("Введите позицию элемента (через пробел)");
var xy = Console.ReadLine().Split(" ").Select(p => int.Parse(p)).ToArray();

if (xy[0] - 1 > arrays.Length || xy[1] - 1 > arrays[0].Length)
{
    Console.WriteLine("Такого элемента в массиве нет");
    return;
}
Console.WriteLine(arrays[xy[0] - 1][xy[1] - 1]);