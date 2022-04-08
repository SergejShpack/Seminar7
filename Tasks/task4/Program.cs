// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

Console.Write("Введите размер сторон треугольника: ");
int numberRows = int.Parse(Console.ReadLine() ?? "5");

long Factorial(int n)
{
    if (n == 1 || n == 0) return 1;
    else return n * Factorial(n - 1);
}


for (int i = 0; i < numberRows; i++)
{
    for (int j = 0; j <= (numberRows - i); j++)
    {
        Console.Write("   ");
    }
    for (int j = 0; j < i + 1; j++)
    {
        long numberPascal = Factorial(i) / (Factorial(j) * Factorial(i - j));
        Console.Write(String.Format("{0,6}", numberPascal));
    }
    Console.WriteLine();
}