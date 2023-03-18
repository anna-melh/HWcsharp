// СЕМИНАР 3
// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void CheckKoord(int x, int y)
// {

//     if (x>0 && y>0)
//         Console.WriteLine("четверть № 1");
//     else if (x>0 && y<0)
//         Console.WriteLine("четверть № 4");
//     else if (x<0 && y<0)
//         Console.WriteLine("четверть № 3");
//     else if (x<0 && y>0)
//         Console.WriteLine("четверть № 2");
//     else
//         Console.WriteLine("Точка находится на координатной оси");
// }

// int CheckKoord2(int x, int y)
// {
//     int res = 0;
//     if (x>0 && y>0)
//         res =1;
//     else if (x>0 && y<0)
//         res=4;
//     else if (x<0 && y<0)
//         res=3;
//     else if (x<0 && y>0)
//         res=2;
//     return res;
// }


// Console.WriteLine("Введите координату X");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату Y");
// int y = Convert.ToInt32(Console.ReadLine());
// // CheckKoord(x,y);
// // CheckKoord(8, -8);
// int vivod = CheckKoord2(x,y);
// Console.WriteLine($"Точка находится в четверти № {vivod}");

// Напишите программу, которая по заданному номеру четверти, показывает диапазон 
// возможных координат точек в этой четверти (x и y).

// Console.WriteLine("Введите номер четверти");
// int nomerChetvert = Convert.ToInt32(Console.ReadLine());
// Chetvert(nomerChetvert);

// void Chetvert(int nomerChetvert)
// {
//         if (nomerChetvert==1)
//         Console.WriteLine("Ваша точка находится в области x>0 и y>0");
//     else if (nomerChetvert==2)
//         Console.WriteLine("Ваша точка находится в области x<0 и y>0");
//     else if (nomerChetvert==3)
//         Console.WriteLine("Ваша точка находится в области x<0 и y<0");
//     else if (nomerChetvert==4)
//         Console.WriteLine("Ваша точка находится в области x>0 и y<0");
//     else
//         Console.WriteLine("Вы ввели число не в диапозоне от 1 до 4");
// }

// программа х, у 
 
// Console.WriteLine ("Введите номер четверти " ); 
// int x = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine(CheckKoord2(x)); 
 
 
// string CheckKoord2(int x) 
// { 
//     string res = "Введены некорректные значения"; 
//     if (x ==1) 
//         res = "x>0, y>0" ; 
//     else if (x ==4) 
//         res = "x>0, y<0" ; 
//     else if (x ==3) 
//         res = "x<0, y<0" ; 
//     else if (x ==2) 
//         res = "x<0, y>0" ; 
//     return res; 
// }

// Напишите программу, 
// которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine ("Введите координату первой точки х" ); 
// int x1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine ("Введите координату первой точки y" ); 
// int y1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine ("Введите координату второй точки х" ); 
// int x2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine ("Введите координату второй точки y" ); 
// int y2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine(Length(x1, x2, y1, y2)); 
 
 
// double Length (int x1, int x2, int y1, int y2) 
// { 
//     return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)); 
// } 

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine ("Введите число N" ); 
// int N = Convert.ToInt32(Console.ReadLine()); 
// Square (N); 
 
// void Square (int N) 
// { 
// for (int i=1;i<=N;i++) 
//     Console.Write(i+"=>"+Math.Pow(i,2)+" "); 
// }

// ДОМАШНЕЕ ЗАДАНИЕ 3

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// int len = number.Length;

// if (len == 5)
// {
//     if (number[0] == number[4] && number[1] == number[3])
//     {
//         Console.WriteLine($"{number} - Палиндром");
//     }
//     else
//     {
//         Console.WriteLine($"{number} - НЕ палиндром");
//     }
// }
// else
// {
//     Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int x1 = ReadInt("Введите координату X первой точки: ");
// int y1 = ReadInt("Введите координату Y первой точки: ");
// int z1 = ReadInt("Введите координату Z первой точки: ");
// int x2 = ReadInt("Введите координату X второй точки: ");
// int y2 = ReadInt("Введите координату Y второй точки: ");
// int z2 = ReadInt("Введите координату Z второй точки: ");

// int A = x2 - x1;
// int B = y2 - y1;
// int C = z1 - z2;

// double length = Math.Sqrt(A * A + B * B + C * C);
// Console.WriteLine($"Длинна отрезка {length}");

// int ReadInt(string message) 
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine()); // Функция ввода сообщения
// }

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int number = ReadInt("Введите число N: ");
for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}