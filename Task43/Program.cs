Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения k1, b1, k2 и b2 задаются пользователем.");

void Execute()
{
    Console.WriteLine("Программа поддерживает дробные числа. Например можно ввести 15,6");
    Console.WriteLine("Введите число k1");
    double k1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите число b1");
    double b1 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите число k2");
    double k2 = double.Parse(Console.ReadLine());
    
    Console.WriteLine("Введите число b2");
    double b2 = double.Parse(Console.ReadLine());

    if (k1.Equals(k2))
    {
        Console.WriteLine($"Линии не пересекаются, так как параллельны");
        return;
    }
    var x = (b2 - b1) / (k1 - k2);
    var y = k1 * x + b1;
    Console.WriteLine($"b1 = {b1}; k1 = {k1}; b2 = {b2}; k2 = {k2} -> ({x}; {y})");
}

Execute();