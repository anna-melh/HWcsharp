// Напишите программу, которая на вход принимает число и выдает его квадрат.
// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine() );
// int res = num*num;
// Console.WriteLine("Квадрат введенного числа равен "+res);

// if (num==5)
// {
//     Console.WriteLine("пятерочка");
// }
// else if (num==3)
//     Console.WriteLine("троечка");
// else
//     Console.WriteLine("НЕ пятерочка и не троечка");

// int start = 1;
// int finish = 30;

// while (start <= finish)
// {
//     Console.Write(start + " ");
//     start ++;
// }

// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа впромежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> "-2, -1, 0, 1, 2"


// Console.Write("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// num = Math.Abs(num);
// // Abs - модуль числа
// int count = -num;
// // создается отрицательное число, чтобы создался цикл
// while(count <= num)
// {
//     Console.Write("{0} ", count);
//     count ++;
// }


// ДОМАШНЕЕ ЗАДАНИЕ 1

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее,
// а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Введите два числа");
// int num1 = Convert.ToInt32(Console.ReadLine());
//     int num2 = Convert.ToInt32(Console.ReadLine());
//     if (num1 >num2)
//         Console.WriteLine(num1);
//     else
//         Console.WriteLine(num2);

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Введите три числа");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Max(num1, Math.Max(num2, num3)));

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 2 == 0)
// {
//     Console.WriteLine("Число четное");
// }
// else Console.WriteLine("Число нечетное");

// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int i = 1;
bool not = true;
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Четные числа от 1 до " + num);
while (i <= num)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
}

if (not)
{
    Console.WriteLine("Нет четных чисел");
}


// Задача 7 HARD по желанию - идет за 2 необязательных Напишите программу, 
// которая принимает на вход целое число любой разрядности и на выходе показывает 
// третью цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.
// 456111 -> 6
// 78 -> нет
// 9146548 -> 4
// 3 -> нет