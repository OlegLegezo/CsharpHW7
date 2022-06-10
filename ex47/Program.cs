// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// метод печати матрицы на экран 
void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)//matrix.GetLength(0) вместо написания руками 3
    {
        for (int j = 0; j < matr.GetLength(1); j++)//matrix.GetLength(0) вместо написания руками 4
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
// метод печати матрицы на экран




// метод заполнения матрицы рандомными числами double
void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Random rand = new Random();
            matr[i, j] = 4 - rand.Next(11) + rand.NextDouble();
            //matr[i, j] = rand.NextDouble(11);
        }
    }
}
// метод заполнения матрицы рандомными числами double

Console.Write("введите m:");
int m = int.Parse(Console.ReadLine());
Console.Write("введите n:");
int n = int.Parse(Console.ReadLine());

double[,] matrix = new double[m, n];

FillArray(matrix);
PrintArray(matrix);