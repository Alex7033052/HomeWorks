Console.WriteLine("Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");

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


var rows = 6;
var columns = 4;
var arrays = GenerateArray(rows, columns);

for (var i = 0; i < arrays.Length; i++)
{
    var list = arrays[i].ToList();
    list.Sort(delegate(int x, int y)
    {
        return x - y;
    });
    arrays[i] = list.ToArray();
}

void PrintArray(IEnumerable<IEnumerable<int>> arrays)
{
    foreach (var list in arrays)
    {
        Console.WriteLine(String.Join(", ", list));
    }
}

Console.WriteLine("В итоге получается вот такой массив:");
PrintArray(arrays);