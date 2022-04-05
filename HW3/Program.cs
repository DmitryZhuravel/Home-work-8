// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
int[,] matrix1 = FillArray(Prompt("Введите количество строк первой матрицы => "), Prompt("Введите количество столбцов первой матрицы => "));
PrintArray(matrix1);
int[,] matrix2 = FillArray(Prompt("Введите количество строк второй матрицы => "), Prompt("Введите количество столбцов второй матрицы => "));
PrintArray(matrix2);
Console.WriteLine("Произведение двух матриц равно: ");
int[,] mult = Mult(matrix1, matrix2);
PrintArray(mult);        
        
int[,] Mult(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(0); j++)
        {
            for (int k = 0; k < matrix2.GetLength(1); k++)
            {
                result[i, k] += matrix1[i, j] * matrix2[j, k];
            }
        }        
    }
    return result;
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

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i - j;
        }
    }
    return array;
}
