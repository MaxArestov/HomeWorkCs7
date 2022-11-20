// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Поиск среднего арифметического в отдельном методе. Для создания массива и вывода можно воспользоваться методами из 47 задачи.
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
double[] arithmeticMean = GetTheArithmeticMean(array);
PrintArray(arithmeticMean);


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

double[] GetTheArithmeticMean(int[,] array)
{
    double[] arMean = new double[array.GetLength(1)];
    for (var j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (var i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        arMean[j] = sum / array.GetLength(0);
    }
    return arMean;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"В столбце {i} среднее арифметическое - {array[i]}");
    }
}