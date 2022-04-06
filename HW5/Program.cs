// Заполните спирально массив 4 на 4 по возрастанию
int row=Prompt("Введите количество строк => ");
int column=row;
int[,] array = new int[row, column];
FillArray(array, row, column);
PrintArray(array);

void PrintArray(int[,] array)
{
    Console.WriteLine("== Вывод массива в консоль ==");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] arr, int row, int col)
{
    int composition = 1, count=0, ik = 0, jk = 0, k = 0; 
    while (composition <= row * column)
    {
        if (count == 0)
        {
            for (int j = jk; j < column - k; j++)
            {
                arr[ik, j] = composition++;
                jk = j;
            }
            count = 1;
            ik++;
        }
        if (count == 1)
        {
            for (int i = ik; i < row - k; i++)
            {
                arr[i, jk] = composition++;
                ik = i;
            }
            count = 2;
            jk--;
        }
        if (count == 2)
        {
            for (int j = jk; j >= column - col + k; j--)
            {
                arr[ik, j] = composition++;
                jk = j;
            }
            count = 3;
            ik--;
        }
        if (count == 3)
        {
            for (int i=ik; i>k; i--)
            {
                arr[i, jk] = composition++;
                ik = i;
            }
            count = 0;
            jk++;
        }
        k++;
    }
}            

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

 