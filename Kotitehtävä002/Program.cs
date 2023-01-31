// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Enter A");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter B");
int B = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter C");
int C = int.Parse(Console.ReadLine()!);

int max = A;

if ( A > max) max = A;
if ( B > max) max = B;
if ( C > max) max = C;

Console.Write("max= ");
Console.WriteLine(max);