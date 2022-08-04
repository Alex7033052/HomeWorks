Console.WriteLine("Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine("Генерирую случайные массивы");
void Execute()
{
    Random rd = new Random();
    var length = rd.Next(3, 10);
    var sum = 0;
    var arr = new List<Int32>();
    for (var i = 0; i < length; i++)
    {
        var number = rd.Next(-100, 100); 
        arr.Add(number);
        if (i % 2 == 1)
        {
            sum += number;
        }
    }

    Console.WriteLine($"[{String.Join(", ", arr)}] -> " + sum);
}

Execute();
Execute();
Execute();