// СЕМИНАР 5
// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

// void FillArray(int [] array )
// {
//     for (int i =0; i<array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }

// void PrintArray(int [] array)
// {
//     foreach (int el in array)
//     {
//         Console.Write($"{el} ");
//     }
//     Console.WriteLine();
// }

// void Summa(int [] array)
// {
//     int sump=0;
//     int sumn=0;
//     for (int i =0; i<array.Length; i++)
//         if (array[i]>0) sump+=array[i];
//         else sumn+=array[i];
//     Console.WriteLine($"Сумма положительных элементов равна {sump}");
//     Console.WriteLine($"Сумма отрицательных элементов равна {sumn}");
// }

// int[] Summa2(int [] array)
// {
//     int sump=0;
//     int sumn=0;
//     for (int i =0; i<array.Length; i++)
//         if (array[i]>0) sump+=array[i];
//         else sumn+=array[i];

//     int[] results = {sump,sumn};
//     return results;
// }

// int [] array  = new int [12];
// FillArray(array);
// PrintArray(array);
// Summa(array);
// int [] rez = Summa2(array);
// PrintArray(Summa2(array));
// Console.WriteLine($"Сумма положительных элементов равна {rez[0]}");
// Console.WriteLine($"Сумма отрицательных элементов равна {rez[1]}");

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие 
// отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// void Array(int [] array)
// {
//     for (int i =0; i<array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }

// void Reverse(int [] array)
// {
//     for (int i =0; i<array.Length; i++)
//         array[i] = -array[i];
// }

// void PrintArray(int [] array)
// {
//     foreach (int el in array)
//     {
//         Console.Write($"{el} ");
//     }
//     Console.WriteLine();
// }

// int [] array  = new int [4];
// Array(array);
// PrintArray(array);
// Reverse(array);
// PrintArray(array);

// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
// void Array(int [] array)
// {
//     for (int i =0; i<array.Length; i++)
//         array[i] = new Random().Next(-9,10);
// }

// void PrintArray(int [] array)
// {
//     foreach (int el in array)
//     {
//         Console.Write($"{el} ");
//     }
//     Console.WriteLine();
// }

// void Poisk(int[] array)
// {
//     Console.Write("Введите ваше число: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     bool find = false;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] == num || array[i] == num*(-1))
//         {
//             // Console.WriteLine("Ваше число есть в массиве");
//             find = true;
//             break;
//         }
//     }
//     Console.WriteLine($"Результат поиска {find}");
// }


// int [] array  = new int [10];
// Array(array);
// PrintArray(array);
// Poisk(array);

// Задача 35: Задайте одномерный массив из 12 случайных чисел от -100 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5,
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// void FillArray(int [] array )  
// {      
//     for (int i =0; i<array.Length; i++)          
//     array[i] = new Random().Next(-100,101);  
// }   
// void PrintArray(int [] array)  
// {      
//     foreach (int el in array)      
//     {          
//         Console.Write($"{el} ");      
//     }      
//     Console.WriteLine();  
// }  
// int Count(int [] array) 
// { 
//     int count=0; 
//     foreach(int el in array) 
//     { 
//         if(el>=10 && el<100) count++ ;           
         
//     } 
//     return count; 
// } 
 
// int [] array  = new int [12];  
// FillArray(array); 
// PrintArray(array); 
// Console.WriteLine($"Количество цифр от 10 до 99 {Count(array)}");

// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 10);
//     }
// }

// void PrintArray(int[] array)
// {
//     foreach (int el in array)
//     {
//         Console.Write($"{el} ");
//     }
//     Console.WriteLine();
// }

// int[] Sum(int[] array)
// {
//     int[] res = new int[array.Length / 2 + array.Length % 2];
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         res[i] = array[i] * array[array.Length - 1 - i];
//     }
//     if (array.Length % 2 != 0)
//     {
//         res[array.Length / 2] = array[array.Length / 2];
//     }

//     return res;

// }


// Console.Write("Введите количество элементов массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];

// FillArray(array);
// PrintArray(array);
// int[] result = Sum(array);
// PrintArray(result);

// ДОМАШНЕЕ ЗАДАНИЕ 5

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// using static System.Console;
// Clear();
// Write("Введите размер массива: ");
// int length = int.Parse(ReadLine()!);
// Write("Введите минимальное значение массива: ");
// int min = int.Parse(ReadLine()!);
// Write("Введите максимальное значение массива: ");
// int max = int.Parse(ReadLine()!);
// int[] Array = GetArray(length, min, max);
// WriteLine($"[{string.Join(", ", Array)}]");
// FindEven(Array);

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     Random rnd = new Random(); // переменная генератор случайных чисел
//     int[] result = new int[size];
//     for(int i = 0; i < result.Length; i++)
//     {
//         result[i] = rnd.Next(minValue, maxValue + 1);
//     }
//     return result;
// }

// void FindEven(int[] MyArray)
// {
//     int even = 0;
//     for (int i = 0; i < MyArray.Length; i++)
//     {
//         if (MyArray[i]%2==0)
//         {
//             even = even + 1;
//         }
//     }
//     WriteLine($"Чётных чисел {even}");
// }


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// using static System.Console;
// Clear();
// Write("Введите размер массива: ");
// int length=int.Parse(ReadLine()!);
// Write("Введите минимальное значение массива: ");
// int min=int.Parse(ReadLine()!);
// Write("Введите максимальное значение массива: ");
// int max=int.Parse(ReadLine()!);
// int[] Array= GetArray(length, min, max);
// WriteLine($"[{string.Join(", ", Array)}]");
// FindOdd(Array);

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     Random rnd= new Random(); // переменная генератор случайных чисел
//     int[] result= new int[size];
//     for(int i = 0; i < result.Length; i++)
//     {
//         result[i] = rnd.Next(minValue, maxValue + 1);
//     }
//     return result;
// }

// void FindOdd(int[] MyArray)
// {
//     int odd = 0;
//     for (int i = 1; i < MyArray.Length; i=i+2)
//     {
//         odd=odd+MyArray[i];
//     }
//     WriteLine($"Сумма чисел на нечётных позициях {odd}");
// }

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using static System.Console;
Clear();
Write("Введите размер массива: ");
int length=int.Parse(ReadLine()!);
Write("Введите минимальное значение массива: ");
int min=int.Parse(ReadLine()!);
Write("Введите максимальное значение массива: ");
int max=int.Parse(ReadLine()!);
int[] Array= GetArray(length, min, max);
WriteLine($"[{string.Join(", ", Array)}]");
FindDifference(Array, max, min);

int[] GetArray(int size, int minValue, int maxValue)
{
    Random rnd= new Random();
    int[] result= new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue + 1);
    }
    return result;
}

void FindDifference(int[] MyArray, int minVal, int maxVal)
{
    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i] < minVal)
        {
            minVal=MyArray[i];
        }
        if(MyArray[i] > maxVal)
        {
            maxVal=MyArray[i];
        }
    }
    WriteLine($"Разница {maxVal-minVal}");
}

// Задача 27. - HARD необязательная Напишите программу, 
// которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9,012 ->4

