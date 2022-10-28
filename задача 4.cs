// задача 4 -напишем программу, которая принимает на вход три числаи выдает максимальное из этих чисел.

Console.Write("вводим первое число: ");
int numb1 =int.Parse(Console.ReadLine()!);

Console.Write("вводим второе число: ");
int numb2 =int.Parse(Console.ReadLine()!);

Console.Write("вводим третье число: ");
int numb3 =int.Parse(Console.ReadLine()!);

if ( numb1 > numb2 && numb1 > numb3 )
     Console.WriteLine($"число { numb1 } наибольшее");

else if ( numb2 > numb3 )
     Console.WriteLine($"число { numb2 } наибольшее");

else
     Console.WriteLine($"число { numb3 } наибольшее"); 
