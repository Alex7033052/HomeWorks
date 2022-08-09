Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");

void Execute()
{
    Console.WriteLine("Введите произвольное количество цифр через запятую");
    var input = Console.ReadLine();
    var count = 0;
    var numbers = input.Split(",").Select(p =>
    {
        var number = int.Parse(p.Trim());
        if (number > 0) count++;
        return number;
    }).ToArray();

    Console.WriteLine($"Результат: {String.Join(", ", numbers)} -> " + count);
    Console.WriteLine();
}

Execute();
Execute();