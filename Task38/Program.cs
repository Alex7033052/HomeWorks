Console.WriteLine("Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");
Console.WriteLine("Генерирую случайные массивы");

void Execute()
{
    Random rd = new Random();
    var length = rd.Next(2, 10);
    var sum = 0;
    var arr = new List<Int32>();
    var max = Int32.MinValue;
    var min = Int32.MaxValue;
    for (var i = 0; i < length; i++)
    {
        var number = rd.Next(-100, 100);
        arr.Add(number);
        max = Math.Max(max, number);
        min = Math.Min(min, number);
    }

    var diff = max - min;
    
    Console.WriteLine($"[{String.Join(", ", arr)}] -> " + diff);
}

Execute();
Execute();
Execute();
Execute();
Execute();