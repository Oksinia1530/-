// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine ("Lisää numero");
int N = Math.Abs(int.Parse(Console.ReadLine()));
int K = -N;
while (K<=N)
{
    Console.Write($"{K} ");
    K++;
}
