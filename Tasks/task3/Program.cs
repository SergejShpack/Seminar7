// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

void FillArray3Dimention(int[,,] arr, int startEl, int endEl)
{
    int el = startEl;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = el;
                el++;
            }
}

void PrintArray3Dimention(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)

        for (int j = 0; j < arr.GetLength(1); j++)
            for (int k = 0; k < arr.GetLength(2); k++)
                Console.WriteLine($"[{i}][{j}][{k}] = {arr[i, j, k]}");

    Console.WriteLine();
}


int n = 4, m = 4, l = 5; // Размер массива
int minArrayElement = 10, maxArrayElement = 99;
int[,,] array = new int[n, m, l];

if (n * m * l < maxArrayElement - minArrayElement + 1)
{
    FillArray3Dimention(array, minArrayElement, maxArrayElement);
    Console.WriteLine("Данная матрица: ");
    PrintArray3Dimention(array);
}
else
{
    Console.WriteLine($"\nНевозможно заполнить массив[{n}][{m}][{l}] не повторяющемися цифрами.\n");
}