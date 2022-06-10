// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого
// столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int a, int b) //метод заполнения массива целыми числами
{
    int[,] array = new int[a, b];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)//0-строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//1-столбцы
        {
            array[i, j] = rnd.Next(0, 10); //или array[i, j]=rnd.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array) //метод печати массива
{
    for (int i = 0; i < array.GetLength(0); i++)//0-строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//1-столбцы
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] arrayResult = GetArray(5, 7);
PrintArray(arrayResult);

double LineMidleSum(int[,] array, int n)//метод среднего арифметического столбца
{
    double answer = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        answer = answer + array[i, n];
        if (i == array.GetLength(0) - 1)
        {
            answer = answer / (i + 1);
        }
    }
    return answer;
}

Console.WriteLine();
//применяю метод внутри цикла for
for (int j = 0; j < arrayResult.GetLength(1); j++)
{
    double Result2 = LineMidleSum(arrayResult, j);
    Console.WriteLine($"среднее арифметическое столбца №{j}: {Result2}");
}
