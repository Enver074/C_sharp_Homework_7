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

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.WriteLine($"Введите размер массива X x Y x Z:");

// Console.WriteLine("Введите X: ");
// int m = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите Y: ");
// int n = int.Parse(Console.ReadLine()!);

// Console.WriteLine("Введите Z: ");
// int l = int.Parse(Console.ReadLine()!);

// int[,,] array3D = new int[m,n,l];
// GetArray(array3D);

// Console.WriteLine($"");
// PrintArray(array3D);

// void PrintArray(int[,,] Array){      // Вывод массива на экран
//     for(int i = 0; i < Array.GetLength(0); i++){
//         for(int j = 0; j < Array.GetLength(1); j++){
//             for(int k = 0; k < Array.GetLength(2); k++){
//                     Console.Write("{0,4}", $"{Array[i,j,k]}{(i, j, k)} ");
//             }
//         }
//         Console.WriteLine();
//     }
// }


// int[,,] GetArray(int[,,] array3D){
//     // Создание одномерного массива заполненный рандомными числами 
//     int [] array = new int[array3D.GetLength(0)*array3D.GetLength(1)*array3D.GetLength(2)];{
//     for(int x = 0; x < array.GetLength(0); x++){
//         array[x] = new Random().Next(10,100);
//         if(x>=1){
//             for (int j = 0; j < x; j++){
//                 while (array[x] == array[j]){
//                 array[x] = new Random().Next(10, 100);
//                     }
//                 }
//             }
//         }
//     }

// // Заполнение трехмерного массива
//     int count=0;
//         for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//         for(int k = 0; k < l; k++){
//             array3D[i,j,k] = array[count];
//             count++; 
//                 }
//             }
//         }
//     return array3D;
// }


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// Console.WriteLine("Введите размер массива: ");
// int a = int.Parse(Console.ReadLine()!);

// int[,] array = FillArray(a,a);

// PrintArray(array);

// void PrintArray(int[,] array){
// for(int x = 0; x < array.GetLength(0); x++){
//     for(int y = 0; y < array.GetLength(1); y++){
//         Console.Write("{0,4}", $"{array[x,y]} ");
//         }
//         Console.WriteLine();
//         }
//         }


// int[,] FillArray(int x, int y){
//     int [,] result = new int[x,y];
//     int temp = 1;
//     int k = 0;

//     if(a%2 == 0)
//     while (temp <= result.GetLength(0) * result.GetLength(1)){
//         for(int j = k; j < result.GetLength(0) - 1 - k; j++){ 
//         result[k,j] = temp;
//         temp++;    
//         }

//         for(int i = k; i < result.GetLength(1) - 1 - k; i++){
//         result[i,result.GetLength(1) - 1 - k] = temp;
//         temp++;      
//         }
//         for(int j = result.GetLength(0) - 1 - k; j > k;  j--){
//         result[result.GetLength(0) - 1 - k,j] = temp;
//         temp++;
//         }

//         for(int i = result.GetLength(1) - 1 - k; i > k; i--){
//         result[i,k] = temp;
//         temp++;      
//         }
//         k++;
//         }

//     if(a%2 != 0)
//     while (temp <= result.GetLength(0) * result.GetLength(1)){

//         for(int j = k; j < result.GetLength(0) - k; j++){ 
//         result[k,j] = temp;
//         temp++;    
//         }

//         for(int i = k + 1; i < result.GetLength(1) - 1 - k; i++){
//         result[i,result.GetLength(1) - 1 - k] = temp;
//         temp++;      
//         }

//         for(int j = result.GetLength(0) - 1 - k; j > k;  j--){
//         result[result.GetLength(0) - 1 - k,j] = temp;
//         temp++;
//         }

//         for(int i = result.GetLength(1) - 1 - k; i > k; i--){
//         result[i,k] = temp;
//         temp++;      
//         }
//         k++;
//         }

//     return result;
//     }