// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите 3D-координаты первой точки:");
if (int.TryParse(Console.ReadLine(), out var x1) && int.TryParse(Console.ReadLine(), out var y1) && int.TryParse(Console.ReadLine(), out var z1))
{
    Console.WriteLine("Введите 3D-координаты второй точки:");
    if (int.TryParse(Console.ReadLine(), out var x2) && int.TryParse(Console.ReadLine(), out var y2) && int.TryParse(Console.ReadLine(), out var z2))
        {
            double result = Math.Sqrt(Math.Pow (x2-x1, 2) + Math.Pow (y2-y1, 2) + Math.Pow (z2-z1, 2));
            Console.WriteLine("Расстояние между точками: " + result.ToString("0.##"));
        }
    else 
        {
            Console.WriteLine("Введено некорректное значение!");
        }
}
else
{
    Console.WriteLine("Введено некорректное значение!");
}
