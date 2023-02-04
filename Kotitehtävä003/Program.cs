// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();

Console.WriteLine("Enter A");
int A = int.Parse(Console.ReadLine()!);
A = A % 2;
if (A==1)
{

Console.WriteLine("Se ei ole parillinen luku");

}
else
{

    Console.WriteLine("Se on parillinen luku");
}
