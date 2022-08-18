using System.Text;

Console.WriteLine("Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.");
Console.WriteLine("Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");


Random rd = new Random();

int[,,] GenerateArray(int xLength, int yLength, int zLength)
{
    var pool = Enumerable.Range(10, 89).ToList();
    var array = new int[xLength, yLength, zLength];
    for (var x = 0; x < xLength; x++)
    {
        for (var y = 0; y < yLength; y++)
        {
            for (var z = 0; z < zLength; z++)
            {
                var index = rd.Next(0, pool.Count);
                array[x, y, z] = pool[index];
                pool.RemoveAt(index);
            }
        }   
    }

    return array;
}

void PrintArray(int[,,] array)
{
    var stringBuilder = new StringBuilder();
    for (var x = 0; x < array.GetLength(0); x++)
    {
        for (var y = 0; y < array.GetLength(1); y++)
        {
            var zLength = array.GetLength(2);
            for (var z = 0; z < zLength; z++)
            {
                stringBuilder.Append(array[x, y, z]);
                stringBuilder.Append($@"({x},{y},{z})");
                if (z < zLength - 1)
                {
                    stringBuilder.Append(", ");
                }
            }
            stringBuilder.AppendLine();
        }
    }   
    Console.Write(stringBuilder.ToString());
}

var array = GenerateArray(3, 2, 4);
Console.WriteLine($@"Массив размером {array.GetLength(0)} x {array.GetLength(1)} x {array.GetLength(2)}");
PrintArray(array);