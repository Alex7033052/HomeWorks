Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");

Random rd = new Random();

int[][] GenerateArray(int rows, int columns)
{
    Console.WriteLine("Сгенерирован массив");
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

var rows = 4;
var columns = 6;
var arrays = GenerateArray(rows, columns);

var averages = new double[columns];
for (var i = 0; i < columns; i++)
{
    var sum = 0;
    for (var j = 0; j < rows; j++)
    {
        sum += arrays[j][i];
    }

    averages[i] = (double)sum / rows;
}

Console.WriteLine("Среднее арифметическое каждого столбца: ");
Console.WriteLine(String.Join(", ", averages));
