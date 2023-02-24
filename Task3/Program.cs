// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix()
{
    int[,] matrix = new int[3, 4];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return (matrix);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double AvarageElementsCol(int[,] array, int col)
{
    double sum = 0;
    int i = 0;
    for(i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, col];
    }
    return sum / i;
}

int[,] matrix = CreateMatrix();
PrintArray(matrix);
for(int j = 0; j < matrix.GetLength(1); j++)
{
    Console.WriteLine($"Среднее арифметическое элементов столбаца № {j+1} равно {AvarageElementsCol(matrix, j)}");
}