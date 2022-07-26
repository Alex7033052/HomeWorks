using HomeWork;

Console.WriteLine("Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("Введите координаты первой точки через запятую, например так: 3,6,8");
var numbers1 = Console.ReadLine().Split(",").Select(p => float.Parse(p.Trim())).ToArray();
if (numbers1.Length != 3)
{ 
    Console.WriteLine("Некорректный ввод. Выход");
    return;
}

Console.WriteLine("Введите координаты второй точки через запятую, например так: 2,1,-7");
var numbers2 = Console.ReadLine().Split(",").Select(p => float.Parse(p.Trim())).ToArray();
if (numbers2.Length != 3)
{ 
    Console.WriteLine("Некорректный ввод. Выход");
    return;
}

Point3D a = new Point3D(numbers1[0], numbers1[1], numbers1[2]);
Point3D b = new Point3D(numbers2[0], numbers2[1], numbers2[2]);

var length = Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2) + Math.Pow(b.Z - a.Z, 2));

Console.WriteLine($"A ({a.X}, {a.Y}, {a.Z}); B ({b.X}, {b.Y}, {b.Z}) -> " + length);