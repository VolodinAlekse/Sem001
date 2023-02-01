// // Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// // (число умноженное на само себя).

// // Например:
// // 4 -> 16 
// // -3 -> 9 
// // -7 -> 49

// Console.Write("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine()); // int.Parse() || Convert.ToInt32

// int result = number * number;
// System.Console.WriteLine("Квадрат числа равен: " + result);


// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

System.Console.WriteLine( "Введите число a");
int numberA=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine( "Введите число b");
int numberB=Convert.ToInt32(Console.ReadLine());

if (numberB*numberB==numberA)
{
    System.Console.WriteLine("да");
}
else {
    System.Console.WriteLine("нет");
}