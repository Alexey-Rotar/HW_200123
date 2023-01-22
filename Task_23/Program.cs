// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите целое положительное число:");
if (!int.TryParse(Console.ReadLine(), out int n) || n<=0) 
{
    Console.WriteLine("Введено некорректное значение!");
}

void nCube(int number) 
{
    for (int i=1; i<=number; i++)
        {
            Console.Write(Math.Pow(i, 3));
            if (i<number) Console.Write(", ");
        }
        Console.WriteLine("");    
}
nCube(n);