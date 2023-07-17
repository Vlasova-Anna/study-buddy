// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int num = Convert.ToInt32 (Console.ReadLine());

if (num==6)
{
Console.WriteLine("Выходной");
}

else if(num<=5)
{
Console.WriteLine("Рабочий день");
}


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число:");

int num1 = Convert.ToInt32(Console.ReadLine());

int result= num1%100/10;
Console.WriteLine(result);
