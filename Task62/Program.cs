using System.Text;


Console.WriteLine("Заполните спирально массив");
Console.WriteLine("Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.");

Console.WriteLine("Задайте число строк");
var rows = int.Parse(Console.ReadLine());
Console.WriteLine("Задайте число колонок");
var columns = int.Parse(Console.ReadLine());

int[,] matrix = new int[rows, columns];
 
int row = 0;
int col = 0;
int dx = 1;
int dy = 0;
int dirChanges = 0;
int visits = columns;
 
for (int i = 0; i < matrix.Length; i++) {
    matrix[row, col] = i + 1;
    if (--visits == 0) {
        visits = columns * (dirChanges % 2) + rows * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }
 
    col += dx;
    row += dy;
}

PrintArray(matrix);

void PrintArray(int[,] array)
{
    var stringBuilder = new StringBuilder();
    for (var x = 0; x < array.GetLength(0); x++)
    {
        var yLength = array.GetLength(1);
        for (var y = 0; y < yLength; y++)
        {
            if (array[x, y] < 10)
            {
                stringBuilder.Append(' ');
            }
            stringBuilder.Append(array[x, y]);
            stringBuilder.Append(' ');
        }
        stringBuilder.AppendLine();
    }
    Console.Write(stringBuilder.ToString());
}