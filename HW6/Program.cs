// СЕМИНАР 6
// Задача 39: Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

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

// void ChangeArray(int [] array)
// {
//    // int temp;
//     for (int i =0; i<array.Length/2; i++)  
//     {
//         // temp = array[i];
//         // array[i] = array[array.Length-1-i];
//         // array[array.Length-1-i] = temp;
//         (array[i] , array[array.Length-1-i]) = (array[array.Length-1-i], array[i]);
//     }
// }


// int [] array = new int [7];
// FillArray(array);
// PrintArray(array);
// ChangeArray(array);
// PrintArray(array);

// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите число 1"); 
// int num1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число 2"); 
// int num2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите число 3"); 
// int num3 = Convert.ToInt32(Console.ReadLine()); 
 
// bool Check ( int num1, int num2, int num3 ) 
// { 
//     bool prov = false; 
//     if (num1<num2+num3 && num2<num1+num3 && num3<num1+num2) 
//         prov = true; 
//     return prov; 
// } 
 
// Console.WriteLine(Check( num1, num2, num3 )); 

// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное. 
// 45 -> 101101 
// 3  -> 11 
// 2  -> 10 
 
 
// Console.WriteLine("Введите десятичное число "); 
// int num1 = Convert.ToInt32(Console.ReadLine()); 
 
// string MetodPreobr ( int num1) 
// { 
//     int num2 = num1; 
//     string result = ""; 
//     while (num2>0) 
//     { 
//         result =  Convert.ToString(num2%2)+ result; 
//         num2 = num2/2; 
//     } 
//     // Console.WriteLine($" result {result}"); 
//     return result; 
// } 
 
// Console.WriteLine(MetodPreobr(num1));

// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число N"); 
// int N = Convert.ToInt32(Console.ReadLine()); 
 
// int [] array = new int[N]; 
 
// void FillArray(int [] array )   
// {       
//     array[0] = 0; 
//     array[1] = 1; 
//     for (int i =2; i<N; i++)     
//         array[i] = array[i-1] + array[i-2]; 
     
// }    
// FillArray(array); 
 
// foreach (int i in array) 
// { 
//     Console.Write(" "+i); 
// } 
 
 
// ДОМАШНЕЕ ЗАДАНИЕ 6

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите числа через запятую: ");
// int[] numbers = StringToNum(Console.ReadLine());
// PrintArray(numbers);
// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > 0)
//     {
//         sum++;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"количество значений больше 0 = {sum}");


// int[] StringToNum(string input)
// {
//     int count = 1;
//     for (int i = 0; i < input.Length; i++)
//     {
//         if (input[i] == ',')
//         {
//             count++;
//         }
//     }

//     int[] numbers = new int [count];
//     int index = 0;

//     for (int i = 0; i < input.Length; i++)
//     {
//         string temp = "";

//         while (input [i] != ',')
//         {
//         if(i != input.Length - 1)
//         {
//             temp += input [i].ToString();
//             i++;
//         }
//         else
//         {
//             temp += input [i].ToString();
//             break;
//         }
//         }
//         numbers[index] = Convert.ToInt32(temp);
//         index++;
//     }
//     return numbers;
// }


// void PrintArray(int[] array)
// {
//     Console.Write("[ ");
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.Write("]");
// }

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Console.WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k1");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите число k2");
// double k2 = Convert.ToInt32(Console.ReadLine());

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
