// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количетсво A строк и B столбцов матрицы 1");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите количетсво C строк и D столбцов матрицы 2");
int C = Convert.ToInt32(Console.ReadLine());
int D = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[A, B];
int[,] array2 = new int[C, D];

if (B != C)
{ Console.WriteLine("Согласно правилам, число столбцов B матрицы 1 должно совпадать с числом строк C матрицы 2!"); }

FillArray(array);
FillArray(array2);
PrintArray(array);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j],4}");
        Console.WriteLine();
    }
}
int[,] MultiMatrix(int[,] array, int[,] array2)
{
    int[,] array3 = new int[array.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array3[i, j] += array[i, k] * array2[k, j];
            }
        }

    }
    return array3;
}
var result = MultiMatrix(array, array2);
PrintArray(result);