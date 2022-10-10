// Методы

double[,] FillRealArray(int rows, int columns)
{
    double[,] filledArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 1);
        }
    }
    return filledArray;
}


int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] filledArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            filledArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return filledArray;
}

void PrintRealArray(double[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write("\t" + inputArray[i, j]);
        }
        Console.WriteLine();
    }
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write("\t" + inputArray[i, j]);
        }
        Console.WriteLine();
    }
}


void task1()
{
    // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
    // m = 3, n = 4.
    // 0,5 7 -2 -0,2
    // 1 -3,3 8 -9,9
    // 8 7,8 -7,1 9

    Console.Clear();
    Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = int.Parse(Console.ReadLine());

    double[,] array = FillRealArray(rowCount, columnCount);
    PrintRealArray(array);

    Console.ReadKey();
}


void task2()
{
    // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
    // и возвращает значение этого элемента или же указание, что такого элемента нет.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // 17 -> такого числа в массиве нет

    Console.Clear();
    Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = int.Parse(Console.ReadLine());

    int[,] array = FillArray(rowCount, columnCount, 1, 10);
    PrintArray(array);

    Console.WriteLine("Введите индекс строки");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите индекс столбца");
    int b = int.Parse(Console.ReadLine());

    if (a > array.GetLength(0) || b > array.GetLength(1))
        Console.WriteLine("Элемента с данным индексом в массиве нет");
    else
        Console.WriteLine($"Искомый элемент: {array[a, b]}");

    Console.ReadKey();
}


void task3()
{
    // Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
    // Например, задан массив:
    // 1 4 7 2
    // 5 9 2 3
    // 8 4 2 4
    // Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

    Console.Clear();
    Console.WriteLine("Введите количество строк двумерного массива");
    int rowCount = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите количество столбцов двумерного массива");
    int columnCount = int.Parse(Console.ReadLine());

    int[,] array = FillArray(rowCount, columnCount, 1, 10);

    PrintArray(array);
    
    for (int j = 0; j < columnCount; j++)
    {
        double sum = 0;
        double aver = 0;
        for (int i = 0; i < rowCount; i++)
        {
            sum += array[i, j]; 
            aver = sum / array.GetLength(0);
        }
        Console.WriteLine("Среднее арифметическое столбца " + (j + 1) + " равно: " + aver);
    }
       
    Console.ReadKey();
}



void Main()
{
    Console.Clear();
    Console.WriteLine("\n Выберите задачу:\n\t1 - Задача 47 \n\t2 - Задача 50 \n\t3 - Задача 52 \n\t4 - Выйти");
    int num = Convert.ToInt32(Console.ReadLine());
    switch (num)
    {
        case 1:
            task1();
            Main();
            break;
        case 2:
            task2();
            Main();
            break;
        case 3:
            task3();
            Main();
            break;
        case 4:
            break;
    }
}
Main();