// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите количество столбцов: ");
// int n = int.Parse(Console.ReadLine()!);

// double[,] array = GetArray(m,n, -100, 100);
// PrintArray(array);


// void PrintArray(double[,] Array){
//     for(int i = 0; i < Array.GetLength(0); i++){
//         for(int j = 0; j < Array.GetLength(1); j++){
//             Console.Write("{0,5}",$"{Array[i,j]/10}");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] GetArray(int m, int n, int minValue, int maxValue){
//     double [,] result = new double[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue+1);
//         }
//     }
//     return result;
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3


// int[,] array = GetArray(3,4,0,10);

// PrintArray(array);
// Console.WriteLine();

// average(array);

// double[] average(int[,] array){
//     Console.Write($"Среднее арифметическое каждого столбца: ");
//     double[] sum=new double [4];
//     for (int i=0; i < array.GetLength(1); i++)
//     {
//         for(int j=0; j < array.GetLength(0); j++)
//         {
//             sum[i] += array[j, i];
//         }
//         Console.Write(Math.Round(sum[i] / array.GetLength(0), 2) + " ");
//     }
//     return sum;
//     }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// i = 4, j = 2 -> такого числа в массиве нет
// i = 1, j = 2 -> 2


// int[,] Array = GetArray(5,5,-50,50);

// Console.WriteLine("Введите номер строки(от 0 до 4)");
// int i = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите номер столба(от 0 до 4)");
// int j = int.Parse(Console.ReadLine()!);


// PrintArray(Array);
// Pos(Array);

// void Pos (int[,] Array){
//     if (i>Array.GetLength(0)|| j > Array.GetLength(1)){
//         Console.WriteLine("такого числа в массиве нет");
//     }
//     else {        
//          Console.WriteLine($"{Array[i,j]}");
//             }
// }


// void PrintArray(int[,] Array){
//     for(int i = 0; i < Array.GetLength(0); i++){
//         for(int j = 0; j < Array.GetLength(1); j++){
//             Console.Write("{0,4}", $"{Array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int [,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue,maxValue + 1);
//         }
//     }
//     return result;
// }
