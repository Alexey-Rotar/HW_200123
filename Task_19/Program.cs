// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

// Программа обрабатывает не только пятизначные числа, но и любые другие в размерности ulong

Console.WriteLine("Введите число для проверки на полиндром:");
if (ulong.TryParse(Console.ReadLine(), out var number) && number>=0)
{   
    ulong a=number; 
    int count;
    for (count=0; a>0; count++)
    {
        a/=10;
    }
    for (int i=0; i<count/2; i++)
    {
        if (    (number%Math.Pow(10, i+1) - number%Math.Pow(10, i)) / Math.Pow(10, i)   !=  (number%Math.Pow(10, count-i) - number%Math.Pow(10, count-1-i)) / Math.Pow(10, count-1-i)   )
        {
            Console.WriteLine("Нет, не палиндром.");
            return;
        } 
    }
Console.WriteLine("Да, палиндром.");
}
else
    Console.WriteLine("Введено некорректное значение!");