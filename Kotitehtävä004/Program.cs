﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();

Console.WriteLine("Enter A");
int A = int.Parse(Console.ReadLine()!);
int start = 0;
while (start <= A)
{
    if (start % 2 == 0)
    {
        Console.Write($"{start} ");
    }

    start++;
}