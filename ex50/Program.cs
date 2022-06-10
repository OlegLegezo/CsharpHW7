// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


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

Console.Write("введите номер строки: ");
int m = int.Parse(Console.ReadLine());
Console.Write("введите номер столбца: ");
int n = int.Parse(Console.ReadLine());

void Founding(int[,] array, int m, int n)//метод поиска элемента в массиве по координатам
{
    bool answerBool = false;
    int answer = 0;
    if (m <= array.GetLength(0) & n <= array.GetLength(1))
    {
        answerBool = true;
        answer = array[m, n];
        Console.WriteLine($"по введенным параметрам элемент в массиве: {answer}");
    }
    else
    Console.WriteLine("по введенным параметрам элемент в массиве отсутствует");
}

Founding(arrayResult, m, n);

