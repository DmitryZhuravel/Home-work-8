// Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет 
// построчно выводить массив, добавляя индексы каждого элемента.
int[,,] myArray= MyArray(2, 5, 5);
PrintMyArray(myArray);
Console.WriteLine("Трехмерный массив:");
PrintRowbyRowArray(myArray);

int GenerateUniqueNumber()
{
    HashSet<int> numbers = new HashSet<int>();;
    Random rnd = new Random();
    while (true)
    {
        int n = rnd.Next(10, 100);
        if (!numbers.Contains(n))
        {
            numbers.Add(n);
            return n;
        }
    }
}

int[,,] MyArray(int row, int column, int plane)
{
    int[,,] myArray = new int[row, column, plane];
    Random rnd = new Random();
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(2); k++)
            {
                myArray[i, j, k] =GenerateUniqueNumber();
            }  
        }
    }
    return myArray;
}

void PrintMyArray(int[,,] array)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        Console.WriteLine("=== Page N: " + (i + 1)+" ===");
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(2); k++)
            {
                Console.Write($"{myArray[i, j, k]}\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine(" ");
    }
}

void PrintRowbyRowArray(int[,,] array)
{               
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            for (int k = 0; k < myArray.GetLength(2); k++)
            {
               Console.WriteLine($" Элемент трехмерного массива с индексом [ {i}, {j}, {k}] имеет значение {myArray[i,j,k]} "); 
            }
            
        }
    }
}


