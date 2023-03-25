// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// int Summa(int num)
// {
//     int sum=0;
//     for (int i =1; i<=num;i++)
//         sum+=i; // sum = sum + i;
//     return sum;
// }

// Console.WriteLine("Введите целое число");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма всех чисел от 1 до {num} равна {Summa(num)}");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Иное решение - правильное

// Console.Write("Введите число А: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int count = 0; //количество цифр в числе

// while (A > 0)
// {
//     A /= 10; // A = A/10
//     count++;
// }
// Console.WriteLine($"Количество цифр в числе = {count}");

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Вещественное число

// int Index(double num)
// {
//     int count = 0;
//     while ((num % 1) > 0)
//     {
//         num = (num * 10);
//         Console.WriteLine(num);
//     }
//     while (num > 1)
//     {
//         num = (num / 10);
//         count = count +1;
//     }
//     return count;
// }

// Console.WriteLine("Введите число");
// double num = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(Index(num));


// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int Factorial(int n){
//   int rst = 1;
//   for (int i = 1; i <= n; i++){
//     rst = rst * i;
//   }
//   return rst;
// }

// Console.WriteLine(Factorial(5));


// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный 
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]
  
// int[] CreateArr(){
//   int[] tempArr = new int[8];
//   for (int i = 0; i < tempArr.Length; i++){
//     int randomNum = new Random().Next(0, 2);
//     tempArr[i] = randomNum;
//   }
//   return tempArr;
// }

// void PrintArr(int[] tempArr){
//   foreach (int i in tempArr){
//       Console.Write(i + " ");
//   }
// }

// int[] arr = CreateArr();
// PrintArr(arr);

// Доп. задание
// Написать ф-ю true если единиц больше, чем нулей иначе false

// int[] CreateArr(){
//   int[] tempArr = new int[8];
//   for (int i = 0; i < tempArr.Length; i++){
//     int randomNum = new Random().Next(0, 2);
//     tempArr[i] = randomNum;
//   }
//   return tempArr;
// }

// void PrintArr(int[] tempArr){
//   foreach (int i in tempArr){
//       Console.Write(i + " ");
//   }
// }

// bool NumCheck(int[] tempArr){
//   int countOne = 0;
//   int countZero = 0;

//   for (int i = 0; i < tempArr.Length; i++){
//     if(tempArr[i] == 0) countZero++;
//     else countOne++;
//   }
//   return countOne > countZero ? true: false;
// }

// int[] arr = CreateArr();
// PrintArr(arr);
// Console.WriteLine();
// Console.WriteLine(NumCheck(arr));