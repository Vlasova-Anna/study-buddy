﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num<0) 
{
    Console.WriteLine($"сделайте число {num} неотрицательным, ответу не верьте - на мой взгляд,");
}

if(num<=99) 
{
    Console.WriteLine("третьей цифры нет");
}

while (num>999)
{
num=num/10; 
}

if (num<=999)
{
       {
    num=(num%10);
       }

Console.WriteLine(num);
}

// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число:");

int num1 = Convert.ToInt32(Console.ReadLine());

int result= num1%100/10;
Console.WriteLine(result);

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int num3 = Convert.ToInt32 (Console.ReadLine());

if (num3==6)
{
Console.WriteLine("Выходной");
}

if (num3==7)
{
Console.WriteLine("Выходной");
}

if(num3<=5)
{
Console.WriteLine("Нет, увы о_о - Рабочий день");
}
