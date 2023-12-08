using System;

class Program
{
    static void Main()
    {
        // Создаем прямоугольный двумерный массив
        int[,] array = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

        // Выводим исходный массив
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Инициализируем переменные для хранения индекса и суммы строки с наименьшей суммой элементов
        int minSumRow = 0;
        int minSum = int.MaxValue;

        // Находим строку с наименьшей суммой элементов
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            int rowSum = 0;
            for (int j = 0; j < columns; j++)
            {
                rowSum += array[i, j];
            }
            if (rowSum < minSum)
            {
                minSum = rowSum;
                minSumRow = i;
            }
        }

        // Выводим строку с наименьшей суммой элементов
        Console.WriteLine("Строка с наименьшей суммой элементов:");
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[minSumRow, j] + " ");
        }
        Console.WriteLine();
    }

    // Метод для вывода массива
    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}