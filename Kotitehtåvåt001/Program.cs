// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Lisää A");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine("Lisää B");
int B = int.Parse(Console.ReadLine()!);
if (A > B) 
{

    Console.WriteLine($"Numero {A} on suurempi kuin {B}");

}
else 
{

    Console.WriteLine($"Numero {A} on pienempi kuin {B}");

}