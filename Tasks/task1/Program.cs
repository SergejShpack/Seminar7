// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

void FillArray(int[,] arr, int startEl, int endEl)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = rnd.Next(startEl, endEl + 1);
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
           
            Console.Write(String.Format("{0,4}", arr[i, j]));
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ChangeArrayColumnsRow(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < arr.GetLength(1); j++)
        {
            int temp;
            temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }

    }
}

int n = 4, m = 4; // Размер массива
int minArrayElement = 0, maxArrayElement = 10;
int[,] array = new int[n, m];

FillArray(array, minArrayElement, maxArrayElement);
Console.WriteLine("Данная матрица: ");
PrintArray(array);

if (array.GetLength(0) == array.GetLength(1))
{
    Console.WriteLine("Измененная матрица: ");
    ChangeArrayColumnsRow(array);
    PrintArray(array);
}
else Console.WriteLine($"Размер массива {array.GetLength(0)}, {array.GetLength(1)} Невозможно поменять колонки и столбцы.");
