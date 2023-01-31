// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine ("Valitse kolminumeroinen numero");
int num = int.Parse(Console.ReadLine()!);
int kon = num % 10;
Console.WriteLine(kon);