/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

// Console.WriteLine("Введите количество столбцов");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int n = Convert.ToInt32(Console.ReadLine());
// double[,] a = new double[m, n];
 
// Random random = new Random();
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         a[i, j] = random.Next(100);
//         a[i, j] = random.NextDouble() * 100;
//         Console.Write("{0,6:F1}", a[i, j]);
//     }
//     Console.WriteLine();
// }


/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
[1,7] -> такого элемента в массиве нет*/

// Console.WriteLine("Введите количество столбцов");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество строк");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m, n];
 
// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         array [i, j] = Convert.ToInt32(new Random().Next(1,100));  
// }
 
// for (int i = 0; i < array.GetLength(0); i++) 
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//         Console.Write(array[i,j] + "\t ");
//         Console.WriteLine();
// }
 
//  Console.WriteLine("Введите индекс числа");
//  int a = Convert.ToInt32(Console.ReadLine());
//  int b = Convert.ToInt32(Console.ReadLine());
// if (a>m && b>n)
//  Console.WriteLine("Вы вышли за пределы массива");
//  else
//  {
//  Console.WriteLine(array[a,b]);
//  }



/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.WriteLine("Введите количество столбцов");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(1,100));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t ");
        Console.WriteLine();
}


// пока не сообразил как доделать