// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int Prompt (string message)
{
    Console.Write(message);
    return int.Parse (Console.ReadLine());
}
double [,] GenerateArray (int row, int column, int min, int max)
{
    var array = new double[row,column];
    var rnd = new Random();
    for (int i=0; i< array.GetLength(0); i++)
    {
        for (int j=0; j< array.GetLength(1);j++)
        {
            array[i,j]=rnd.Next (min, max +1) + new Random().NextDouble();
        }
    }
    return array;
}

void PrintArray (double [,] array)
{
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1);j++)
        {
            Console.Write($"{array[i,j]:f1}" +"\t");
        }
        Console.WriteLine();
    }
}

int row =Prompt ("Введите количество строк: ");
int column =Prompt ("Введите количество столбцов: ");
int min = 1;
int max = 10;
double[,] array = GenerateArray (row, column, min, max);
PrintArray(array);