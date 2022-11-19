// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();

Console.WriteLine("Введите m - ");
bool checkM = int.TryParse(Console.ReadLine(), out  int m);

Console.WriteLine("Введите n - ");
bool checkN = int.TryParse(Console.ReadLine(), out  int n);

if (!checkM || !checkN)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] array = CreateRandom2DArray(m,n);
Print2DArray(array);

Console.WriteLine("Введите 2 числа, обозначающие место в массиве, разделяя их клавишей Enter:");
bool parseX = int.TryParse(Console.ReadLine(), out int x);

bool parseY = int.TryParse(Console.ReadLine(), out int y);

if (!parseX || !parseY)
{
    Console.WriteLine("Ошибка!");
    return;
}
Console.WriteLine($"Значение на указанной позиции - {GetValueFromArray(array, x, y)}");



int GetValueFromArray(int[,] array, int row, int column)
{
    int value;
    if (row > array.GetLength(0) || column > array.Length / (array.GetUpperBound(0) + 1))
    {
        Console.WriteLine("Значение выходит за границы предоставленного массива");
        Console.ReadLine();
        return -1;
    }
    else
    {
        value = array[row, column];
        return value;
    }
}

int[,] CreateRandom2DArray(int m, int n)
{
    int[,] array = new int[m, n];

    Random random  = new Random ();

    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = random.Next(1, 10);
        }
    }

    return array;
}

void Print2DArray(int[,] array)
{
    for (var i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}