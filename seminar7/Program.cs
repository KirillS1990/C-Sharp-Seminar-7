// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.Clear();
// System.Console.WriteLine("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] massiv = new double[m, n];
// Random sluch = new Random();
// for (int i = 0; i < massiv.GetLength(0); i++)
// {
//     for (int j = 0; j < massiv.GetLength(1); j++)
//     {
//         massiv[i, j] = sluch.NextDouble() * 20 - 10;
//         Console.Write("{0,6:F1}", massiv[i, j]);
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Clear();
// int[,] massiv = new int[4, 4];
// Random sluchay = new Random();
// int counterLine = 0;
// int counterColomn = 0;
// for (int i = 0; i < massiv.GetLength(0); i++)
// {
//     for (int j = 0; j < massiv.GetLength(1); j++)
//     {
//         massiv[i, j] = sluchay.Next(1, 9);
//         Console.Write($"{massiv[i, j]}\t");
//         counterColomn++;
//     }
//     Console.WriteLine();
//     counterLine++;
// }
// Console.WriteLine("Введите строку массива: ");
// int line = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите столбец массива: ");
// int column = Convert.ToInt32(Console.ReadLine());
// if (line <= counterLine && column <= counterColomn)
// {
//     Console.WriteLine($"Значение выбранного элемента: {massiv[line - 1, column - 1]}");
// }
// else
// {
//     Console.WriteLine("Такого элемента нет, вы вышли за пределы массива.");
// }




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.Clear();
// System.Console.WriteLine("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] massiv = new int[m, n];
// Random sluchay = new Random();
// double numLine = 0;
// for (int i = 0; i < massiv.GetLength(0); i++)
// {
//     for (int j = 0; j < massiv.GetLength(1); j++)
//     {
//         massiv[i, j] = sluchay.Next(1, 15);
//         Console.Write($"{massiv[i, j]}\t");
//     }
//     Console.WriteLine();
//     numLine++;
// }
// Console.Write("Среднее арифметическое каждого столбца: ");
// int sum = 0;
// for (int j = 0; j < massiv.GetLength(1); j++)
// {
//     for (int i = 0; i < massiv.GetLength(0); i++)
//     {
//         sum = sum + massiv[i, j];
//     }
//     Console.Write("{0,6:F1}", sum / numLine);
//     sum = 0;
// }

