using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // Двумерный массив

        Console.Write("Введите номер строки: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int column = int.Parse(Console.ReadLine());

        int value = GetElementValue(matrix, row, column);

        if (value != -1)
        {
            Console.WriteLine("Значение элемента: " + value);
        }
        else
        {
            Console.WriteLine("Такого элемента не существует.");
        }
    }

    static int GetElementValue(int[,] matrix, int row, int column)
    {
        int rows = matrix.GetLength(0);
        int columns = matrix.GetLength(1);

        if (row >= 0 && row < rows && column >= 0 && column < columns)
        {
            return matrix[row, column];
        }
        else
        {
            return -1;
        }
    }
}