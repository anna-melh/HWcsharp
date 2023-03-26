// СЕМИНАР

// // Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// // N = 5 -> "1, 2, 3, 4, 5" 
// // N = 6 -> "1, 2, 3, 4, 5, 6" 
 
// Console.WriteLine("Введите число N"); 
// int N = Convert.ToInt32(Console.ReadLine()); 
// NumRec(N); 
 
// Console.WriteLine(NumRec(N)); 
 
// string NumRec(int N) 
// { 
//     if (N==1) return Convert.ToString(N); // строчки 13 и 14 
//     return NumRec(N-1) + " " + Convert.ToString(N);  //строчки 15 и 16 
// }
// // Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// // M = 1; N = 5 -> "1, 2, 3, 4, 5" 
// // M = 4; N = 8 -> "4, 6, 7, 8" 
 
// Console.WriteLine("Введите число M"); 
// int M = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число N"); 
// int N = Convert.ToInt32(Console.ReadLine()); 
 
// Console.WriteLine(NumRec(N,M)); 
 
// string NumRec(int N, int M) 
// { 
//     if (N==M) return Convert.ToString(M); // строчки 13 и 14 
//     return NumRec(N-1,M) + " " + Convert.ToString(N);  //строчки 15 и 16 
// }

// // Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// // 453 -> 12
// // 45 -> 9
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма цифр числа N: {SumRec(N)}");

// int SumRec(int N)
// {
//     if(N == 0) return 0;
//     return N%10 + SumRec(N/10);
// }

// // Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// // A = 3; B = 5 -> 243 (3⁵)
// // A = 2; B = 3 -> 8
// Console.Write("Введите число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Число А в степени В: {Stepen(A,B)}");

// int Stepen(int A, int B)
// {
//     if(B == 0) return 1;
//     return A*Stepen(A,B-1);
// }


// ДОМАШНЕЕ ЗАДАНИЕ
// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите натуральное число больше 1:");
// int number = int.Parse(Console.ReadLine());

// ///Метод вывода натуральных чисел от N до 1:
// void NumberCounter (int number)
// {
//     if (number < 0) Console.Write($"{number} не натуральное число");
//     if (number == 0) return;
//     Console.Write("{0,4}", number);
//     NumberCounter (number - 1);
// }

// NumberCounter(number);

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// SumFromMToN(m, n);

// // вызов функции "сумма чисел от M до N"
// void SumFromMToN(int m, int n)
// {
//     Console.Write(SumMN(m - 1, n));
// }

// // функция сумма чисел от M до N
// int SumMN(int m, int n)
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}