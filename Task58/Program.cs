Console.WriteLine("Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");

Random rd = new Random();

int[,] Multiplication(int[,] a, int[,] b)
{
    if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i,j] += a[i,k] * b[k,j];
            }
        }
    }
    return r;
}
void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write("{0} ", a[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] GenerateArray(int rows, int columns)
{
    var array = new int[rows, columns];
    for (var i = 0; i < rows; i++)
    {
        for (var j = 0; j < columns; j++)
        {
            array[i, j] = rd.Next(0, 9);
        }
    }

    return array;
}

Console.WriteLine("Введите размерность первой матрицы: ");
int[,] A = GenerateArray(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("Введите размерность второй матрицы: ");
int[,] B = GenerateArray(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

Console.WriteLine("\nМатрица A:");
Print(A);
Console.WriteLine("\nМатрица B:");
Print(B);
Console.WriteLine("\nМатрица C = A * B:");
int[,] C = Multiplication(A, B);
Print(C);