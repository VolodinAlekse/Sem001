﻿// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32

int result = number * number;
System.Console.WriteLine("Квадрат числа равен: " + result);
