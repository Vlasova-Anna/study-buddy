// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Привет, хочешь узнать, какое из этих чисел больше?");
Console.WriteLine("Введи первое число - ");

int A = Convert.ToInt32 (Console.ReadLine());

Console.WriteLine("Введи второе число - ");

int B = Convert.ToInt32(Console.Read());
if(A > B)
{
Console.WriteLine("Первое число больше! Значит, второе -меньше.");
}
else
{
Console.WriteLine("Второе число больше! Значит, первое -меньше.");
}



// // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// // 2, 3, 7 -> 7
// // 44 5 78 -> 78
// // 22 3 9 -> 22

// int max = 0;

// Console.WriteLine("Введите число");
// int a = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите число");
// int b = Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите число");
// int c = Convert.ToInt32 (Console.ReadLine());

// max=a;
// if (b>max)
// {max=b;
// }
// if (c>max)
// {max=c;
// }
// int result= max;
// Console.WriteLine(result);



// // Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// //  является ли число чётным (делится ли оно на два без остатка).
// // 4 -> да
// // -3 -> нет
// // 7 -> нет

// Console.WriteLine("Введите число");
// int Num = Convert.ToInt32 (Console.ReadLine());

// if (Num%2 == 0)
// {
// Console.WriteLine("Ваше число чётное!");
// }
// else
// {
// Console.WriteLine("Ваше число нечётное!");
// }



// // Задача 8: Напишите программу, которая на вход принимает число (N), 
// // а на выходе показывает все чётные числа от 1 до N.
// // 5 -> 2, 4
// // 8 -> 2, 4, 6, 8

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32 (Console.ReadLine());

// int startpoint = 1;
// while (startpoint < N)
// {
// Console.WriteLine(startpoint+1);
// startpoint+= 2;
// }

