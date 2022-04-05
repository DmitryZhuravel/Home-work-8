// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
int[,] array = FillArray(Prompt("Введите количество строк => "), Prompt("Введите количество столбцов => "));
PrintArray(array);
Console.WriteLine();
MinRowSum(args);

void MinRowSum(string[] args)
{
    int minRowSum = int.MaxValue, indexMinRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            rowSum += array[i, j];

        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            indexMinRow = i;
        }
    }
    Console.WriteLine("Строка с минимальной суммой элементов");
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[indexMinRow, j] + "\t");
    Console.WriteLine();
    Console.WriteLine($"Строка номер {indexMinRow+1} с минимальной суммой элементов {minRowSum}");
}

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 6);
        }
    }
    return array;
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

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}