// задача 8. напишите программу,которая на вход,принимает число (N). 
// а на выходе показывает все четные числа от 1 до N

Console.Write("введите уже число,любое: ");
int number = int.Parse(Console.ReadLine()!);
int beginCount = 2;
while(beginCount <= number)
{ 
    Console.Write($"{ beginCount } ");
}
