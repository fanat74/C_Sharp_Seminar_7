﻿// Задача 48: Задайте двумерный массив размером mxn,
// каждый элемент в массиве находится по формуле Amn=m+n
// Выведите полученный массив на экран.

//     0   1   2   3

// 0   0   1   2   3
// 1   1   2   3   4
// 2   2   3   4   5

int[,] CreateMatrixSumPosInt(int raws, int columns)
{
    int[,] matrix = new int[raws, columns];

        for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i+j;
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write($"{matrix[i,j], 6} ");
        }
        Console.WriteLine("|");
    }
}

int[,] array2D=CreateMatrixSumPosInt(7, 10);
PrintMatrix(array2D);
