// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
//  Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет
// 1, 2 -> 4

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

int InputInt(string message)
{
    Console.Write($"{message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void CheckPrint(int[,] matrix, int row, int col)
{
    if(row - 1 <= matrix.GetLength(0) && col - 1 <= matrix.GetLength(1))
    {
        Console.WriteLine($"Значение искомого элемента равно {matrix[row - 1, col - 1]}");
    }
    else
    {
        Console.WriteLine($"Такого элемента нет в массиве");        
    }
}
int[,] matrix = CreateMatrix();
PrintArray(matrix);
int row = InputInt("Введите номе строки > ");
int col = InputInt("Введите номе столбца > ");
CheckPrint(matrix, row, col);