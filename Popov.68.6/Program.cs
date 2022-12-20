// Элементы матрицы A сделать с помощью генератора случайных чисел.
// Сделать новую матрицу B , в которой удалить с матрицы А ряд,
// в котором минимальный элемент среди элементов главной диагонали.

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 11);
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
            Console.Write("{0}\t", array[i, j]);
        }
        Console.WriteLine(" ");
    }
}

int SearchMin(int[,] array)
{
    int min = array[0, 0];
    int k = 0, p = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min) 
            {
                min = array[i, j];
                k = i;
                p = j;
            }
        }
    }
    Console.Write("The minimum of the array is {0}, i = {1}, j = {2} ", array[k, p], k, p);
    return 10 * k + p;
}


int[,] DeleteColumn(int[,] array, int minElementColumnNumber)
{
    {
        int[,] DeleteColumnArray = new int[array.GetLength(0), array.GetLength(1) - 1];
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < minElementColumnNumber; j++)
            {
                DeleteColumnArray[i, j] = array[i, j];
            }
            for (int j = minElementColumnNumber; j < array.GetLength(1) - 1; j++)
            {
                DeleteColumnArray[i, j] = array[i, j+1];
            }
        }
        return DeleteColumnArray;
    }
}

int[,] DeleteRow(int[,] array, int minElementRowNumber)
{
    {
        int[,] DeleteRowArray = new int[array.GetLength(0)-1, array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < minElementRowNumber; i++)
            {
                DeleteRowArray[i, j] = array[i, j];
            }
            for (int i = minElementRowNumber; i < array.GetLength(1); i++)
            {
                DeleteRowArray[i, j] = array[i+1, j];
            }
        }
        return DeleteRowArray;
    }
}

Console.Write("Enter the number or rows...");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number or columns..");
int columns = int.Parse(Console.ReadLine()!);

Console.WriteLine(" ");

int[,] array = new int[rows, columns];
array = CreateArray(rows, columns);

Console.WriteLine(" ");

PrintArray(array);

Console.WriteLine(" ");

int complex = SearchMin(array);

Console.WriteLine(" ");

int minElementRowNumber = complex / 10;
int minElementColumnNumber = complex % 10;

PrintArray(DeleteRow(DeleteColumn(array, minElementColumnNumber), minElementRowNumber ));
