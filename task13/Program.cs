﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

int number;
Console.WriteLine("Введите число ");
number = Convert.ToInt32(Console.ReadLine());
int a = number%10;
if (a==0)
{
    Console.WriteLine("Третьей цифры нет ");
}
else
{
    Console.WriteLine("Третья цифра " + a);
}