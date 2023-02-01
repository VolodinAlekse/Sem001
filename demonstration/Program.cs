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

// System.Console.WriteLine( "Введите число a");
// int numberA=Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine( "Введите число b");
// int numberB=Convert.ToInt32(Console.ReadLine());

// if (numberB*numberB==numberA)
// {
//     System.Console.WriteLine("да");
// }
// else {
//     System.Console.WriteLine("нет");
// }

// System.Console.Write("Введите число дня недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// switch (day)
// {
//     case 1:
//         System.Console.Write("Понедельник");
//         break;
//     case 2:
//         System.Console.Write("Вторник");
//         break;
//     case 3:
//         System.Console.Write("Среда");
//         break;
//     case 4:
//         System.Console.Write("Четверг");
//         break;
//     case 5:
//         System.Console.Write("Пятница");
//         break;
//     case 6:
//         System.Console.Write("Суббота");
//         break;
//     case 7:
//         System.Console.Write("Воскресенье");
//         break;
//     default:
//         System.Console.Write("Такого дня недели не существует");
//         break;
// }


// if(day==1)
// {
//   System.Console.Write("Понедельник");  
// }
// else if(day==2)
// {
//   System.Console.Write("Вторник");  
// }
// else if(day==3)
// {
//   System.Console.Write("Среда");  
// }
// else if(day==4)
// {
//   System.Console.Write("Четверг");  
// }
// else if(day==5)
// {
//   System.Console.Write("Пятница");  
// }
// else if(day==6)
// {
//   System.Console.Write("Суббота");  
// }
//  else if(day==7)
// {
//   System.Console.Write("Воскресенье");  
// }
//  else
// {
//   System.Console.Write("Такого дня недели не существует");  
// }