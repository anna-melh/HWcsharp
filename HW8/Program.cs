// СЕМИНАР 8

// Задача 53: Задайте двумерный массив.  
// Напишите программу, которая поменяет местами первую  
// и последнюю строку массива. 
 
// Console.WriteLine("Введите кол-во строк "); 
// int n = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите кол-во столбцов "); 
// int m = Convert.ToInt32(Console.ReadLine()); 
 
// int [,] array = new int [n,m]; 
// FillArray(n,m); 
// PrintArray( array); 
// ZamArray(array); 
// PrintArray( array); 
 
// void FillArray (int n, int m) 
// { 
//     for (int i = 0; i<array.GetLength(0); i++) 
//         for (int j = 0; j<array.GetLength(1); j++) 
//             array[i,j] = new Random().Next(-100,101); 
// } 
 
// void PrintArray (int [,] array) 
// { 
//     for (int i=0; i< array.GetLength(0); i++) 
//     { 
//         for (int j=0; j< array.GetLength(1); j++) 
//             Console.Write($"{array[i,j],3} \t"); 
//         Console.WriteLine(); 
//     } 
// Console.WriteLine(); 
// } 
 
// void ZamArray ( int [,] array) 
// { 
//     for (int j = 0; j<array.GetLength(1); j++) 
//         { 
//             (array[0,j],array[array.GetLength(0)-1,j])  
//             = (array[array.GetLength(0)-1,j],array[0,j]); 
//         } 
// } 
 
// Задача 55: Задайте двумерный массив. Напишите программу,  
// которая заменяет строки на столбцы.  
// В случае, если это невозможно, программа должна вывести  
// сообщение для пользователя. 
 
// Console.WriteLine("Введите кол-во строк "); 
// int n = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите кол-во столбцов "); 
// int m = Convert.ToInt32(Console.ReadLine()); 
 
// int [,] array = new int [n,m]; 
// FillArray(n,m); 
// PrintArray( array); 
// ZamArray(array); 
// PrintArray( array); 
 
// void FillArray (int n, int m) 
// { 
//     for (int i = 0; i<array.GetLength(0); i++) 
//         for (int j = 0; j<array.GetLength(1); j++) 
//             array[i,j] = new Random().Next(1,101); 
// } 
 
// void PrintArray (int [,] array) 
// { 
//     for (int i=0; i< array.GetLength(0); i++) 
//     { 
//         for (int j=0; j< array.GetLength(1); j++) 
//             Console.Write($"{array[i,j],3} \t"); 
//         Console.WriteLine(); 
//     } 
// Console.WriteLine(); 
// } 
 
// void ZamArray ( int [,] array) 
// { 
//     for (int i = 0; i<array.GetLength(0); i++) 
         
//         for (int j = i; j<array.GetLength(1); j++) 
//         { 
//             if (n==m) 
//             { 
//                 (array[i,j],array[j,i]) = (array [j,i],array[i,j]); 
//                 // PrintArray(array); 
//             } 
//             else  
//             Console.WriteLine("Невозможна замена"); 
//         } 
// }

// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

// void FillArray(int[,] array)
// {
//     for(int i = 0; i< array.GetLength(0); i++)
//     {
//         for (int j = 0; j< array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(0, 9);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for(int i = 0; i< array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j],3}  ");
//         }
//         Console.WriteLine();
//     }
// }
// void Proverka (int [,] array, int[] arrayline)
// {
//     for(int i = 0; i< array.GetLength(0); i++)
//     {
//         for (int j = 0; j< array.GetLength(1); j++)
//         {
//             arrayline[array[i,j]] ++;
//         }
//     }
// }

// void Print (int[] arrayline)
// {
//     for (int i = 0; i < arrayline.Length; i++)
//     {
//         if(arrayline[i] != 0)
//         {
//             Console.WriteLine($"Элемент {i} встречается {arrayline[i]} раз");
//         }
//     }
// }

// int [,] array = new int [4,4];
// int [] arrayline = new int [10];

// FillArray(array);
// PrintArray(array);
// Proverka(array,arrayline);
// Print(arrayline);

// ДОМАШНЯЯ РАБОТА

// Задача 54:  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] table = new int[3, 4];
// FillArrayRandom(table);
// PrintArray(table);
// SortToLower(table);
// Console.WriteLine();
// PrintArray(table);


// // Функция заполнения массива рандомно числами от 1 до 9
// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// // Функция сортировки элементов в строке двумерного массива, по убыванию
// void SortToLower(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// // Функция вывода двумерного массива
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] table = new int[4, 4];
// FillArrayRandom(table);
// PrintArray(table);
// Console.WriteLine();
// NumberRowMinSumElements(table);


// // Функция вывода номера строки (не индекса) с наименьшей суммой элементов 
// void NumberRowMinSumElements(int[,] array)
// {
//     int minRow = 0;
//     int minSumRow = 0;
//     int sumRow = 0;
//     for (int i = 0; i < table.GetLength(1); i++)
//     {
//         minRow += table[0, i];
//     }
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++) sumRow += table[i, j];
//         if (sumRow < minRow)
//         {
//             minRow = sumRow;
//             minSumRow = i;
//         }
//         sumRow = 0;
//     }
//     Console.Write($"{minSumRow + 1} строка");
// }

// // Функция вывода двумерного массива
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// // Функция заполнения массива рандомно числами от 1 до 9
// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
// int m = InputNumbers("Введите число строк 1-й матрицы: ");
// int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
// int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
// int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine($"Первая матрица:");
// WriteArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine($"Вторая матрица:");
// WriteArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"Произведение первой и второй матриц:");
// WriteArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// На входе - натуральное число от пользователя, например 4.
// Тогда на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int n = 4;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//   sqareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// WriteArray(sqareMatrix);

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }   