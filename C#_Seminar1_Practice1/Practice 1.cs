// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число:");
int num1 = Convert.ToInt32(Console.ReadLine());

int result= num1%100;
int result1= num1%10;
Console.WriteLine(result1);