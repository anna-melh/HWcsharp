// СЕМИНАР 7

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int [,] array = new int [rows, cols];
// FillArray(array);
// PrintArray(array);

// void FillArray(int[,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//         for (int j=0; j<array.GetLength(1);j++)
//             array[i,j] = new Random().Next(-30,31);
// }

// void PrintArray(int[,] array)
// {
//     for (int i=0; i<array.GetLength(0);i++)
//         {
//         for (int j=0; j<array.GetLength(1);j++)
//             Console.Write($"{array[i,j],3} \t");
//         Console.WriteLine();
//         }
// }

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void SqareArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i % 2 != 0 && j % 2 != 0)
//                 array[i, j] = array[i, j] * array[i, j];
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j],3}  ");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] array = new int[3, 4];

// FillArray(array);
// PrintArray(array);
// SqareArray(array);
// Console.WriteLine();
// PrintArray(array);

// ДОМАШНЕЕ ЗАДАНИЕ

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк  ");
// int linesVol = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columnsVol = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[linesVol, columnsVol];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// void FillArrayRandomNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Введите строку: ");
// int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
// Console.Write("Введите столбец: ");
// int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
// int n = 3; 
// int m = 4; 
// Random random = new Random();
// int[,] arr = new int[n, m];
// Console.WriteLine("Исходный массив: ");
// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = 0; j < arr.GetLength(1); j++)
// {
//     arr[i, j] = random.Next(10, 99);
// Console.Write("{0} ", arr[i, j]);
// }
// Console.WriteLine();
// }
//     if (pos1 < 0 | pos1 > arr.GetLength(0) - 1 | pos2 < 0 | pos2 > arr.GetLength(1) - 1)
// {
// Console.WriteLine("Элемент не существует  ");
// }
//     else
// {
//     Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
// }
// Console.ReadLine();


// Console.Write("Введите размерность m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] randomArray = new double[m,n];
// Console.Write("Введите позицию строки: ");
// int m2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите позицию столбца: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// void mas(int m, int n)
// {
// int i,j;
// Random rand = new Random();
// for (i = 0; i < m; i++)
// {
// Console.WriteLine();
// for (j = 0; j < n; j++)
// {
// randomArray[i,j] = rand.NextDouble();
// Console.Write($"{randomArray[i,j]:F2} ");
// }
// Console.WriteLine();
// }
// }
// mas(m,n);
// if (m2<1 || n2<1)
// Console.Write("Позиции строк не могут быть отрицательными");
// else if (m2 <= m+1 && n2 <= n+1)
// Console.Write($"Значение элемента равно {randomArray[m2-1,n2-1]:F2} ");
// else Console.Write("Такого элемента нет в массиве");

// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random random = new Random();
int[,] arr = new int[random.Next(1, 10), random.Next(1, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое каждого столбца:");
Console.WriteLine(arr.GetLength(0));
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    Console.Write($"{ sum / arr.GetLength(0)} ");
}
Console.ReadLine();