// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//  Сделать отдельный метод который генерирует двумерный массив и отдельный метод который выводит его на экран.
// m и n вводит пользователь в консоль
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