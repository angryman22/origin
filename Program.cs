﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число");
// string inputNumber = Console.ReadLine();
// Console.WriteLine($"{inputNumber[1]}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

// Console.WriteLine("Введите число");
// string inputNumber = Console.ReadLine();
// if (Convert.ToInt32(inputNumber) < 100) Console.WriteLine($"В числе {inputNumber} нет третьей цифры");
// else Console.WriteLine($"{inputNumber[2]}");

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите день недели в виде числа от 1 до 7");
string inputNumber = Console.ReadLine();
if (Convert.ToInt32(inputNumber) == 6 || Convert.ToInt32(inputNumber) == 7) Console.WriteLine("Это выходной день");
else Console.WriteLine("Это будний день");