﻿// Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int NumberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

if (NumberA > NumberB)
{
    Console.WriteLine(NumberA + " > " + NumberB);
}
 else if (NumberB > NumberA)
{
    Console.WriteLine(NumberB + " > " + NumberA);
}
else
{
    Console.WriteLine(NumberB + " = " + NumberA);
}
