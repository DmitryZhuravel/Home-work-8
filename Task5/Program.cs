// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника
int n=Prompt("Введите количество строк треугольника Паскаля => ");
Triangle(args);

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int Factorial(int Value)
{
    int fact = 1;
    for (int i = 1; i <= Value; i++)
    {
        fact = fact * i;
    }
return fact;
}

void Triangle(string[] args)
{
    int i, j;
    for (i = 0; i < n; i++)
    {
        for ( j = 0; j <= (n - i); j++)
        {
            Console.Write(" "); 
        }
        for (j = 0; j <= i; j++)
        {
            Console.Write(" "); 
            Console.Write(Factorial(i) / (Factorial(j) * Factorial(i - j))); 
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
