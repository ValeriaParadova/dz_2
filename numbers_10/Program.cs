﻿// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// Например:
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int number1 = number / 10;
int number2 = number1 % 10;

Console.WriteLine(number2);
 