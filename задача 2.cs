//задача 2-написание программы , которая на ВХОД принимает два числа, и выдает ,какое число большее,какое меньшее

Console.Write("вводим число: ");
int numb1 = int.Parse(Console.ReadLine()!);

Console.Write("вводим второе число: ");
int numb2 = int.Parse(Console.ReadLine()!);
if (numb1 > numb2)
{
    Console.WriteLine($"число { numb1 } больше");
}
else if( numb1 == numb2)
     Console.WriteLine($"числа равны");

else
     Console.WriteLine($"число { numb2 } больше");
     