// задача 6- напишите программу,которая на вход принимает число и выдает ,является ли число четным ,
// делится ли оно на два без остатка.

Console.Write ("введите все таки число: ");
int numb = int.Parse(Console.ReadLine()!);

if ( numb % 2 == 0)
     Console.WriteLine("введенное число таки четное");
else
{
     Console.WriteLine("введенное число таки нечетное");
}