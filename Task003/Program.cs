// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
Console.WriteLine ("Lisää viikonpäivän numero");

int num = int.Parse(Console.ReadLine());

if (num == 1)
{

     Console.WriteLine("maanantai");
}
else if (num == 2)
{

     Console.WriteLine("tiistai");
}
else if (num == 3)
{

     Console.WriteLine("keskiviikko");
}
else if (num == 4)
{

     Console.WriteLine("torstai");
}
