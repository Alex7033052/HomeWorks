Console.WriteLine("Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");

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
            array[j] = rd.Next(0, 9);
        }
        Console.WriteLine(String.Join(", ", array));
    }

    return arrays;
}

void PrintArray(IEnumerable<IEnumerable<int>> arrays)
{
    foreach (var list in arrays)
    {
        Console.WriteLine(String.Join(", ", list));
    }
}

var rows = 6;
var columns = 4;
var arrays = GenerateArray(rows, columns);

var minSum = int.MaxValue;
var minRow = -1;
for (var i = 0; i < arrays.Length; i++)
{
    var sum = arrays[i].Aggregate(0, (acc, next) => acc + next);
    if (sum < minSum)
    {
        minRow = i;
        minSum = sum;
    }
}

Console.WriteLine((minRow + 1) + " строка");
