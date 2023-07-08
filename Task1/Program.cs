// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Введите число №1 : ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число №2 : ");
int number2 = int.Parse(Console.ReadLine());
int max = number1;
int min = number1;
if (max < number2) max = number2;
if (min > number2) min = number2;
Console.WriteLine($"Максимальное число {max}, а минимальное число {min} ");