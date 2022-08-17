Console.WriteLine("Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");

Random rd = new Random();

void Execute()
{
    Console.WriteLine("Задайте число строк");
    var rows = int.Parse(Console.ReadLine());
    Console.WriteLine("Задайте число колонок");
    var columns = int.Parse(Console.ReadLine());
    var arrays = new Double[rows][];
    for (var i = 0; i < rows; i++)
    {
        var array = arrays[i] = new Double[columns];
        for (var j = 0; j < columns; j++)
        {
            array[j] = rd.NextDouble() * 100 - 50;
        }
        Console.WriteLine(String.Join(", ", array));
    }
}

Execute();
