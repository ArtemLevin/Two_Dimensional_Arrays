// Дан двумерный массив. Вставьте первую строку после строки, в которой
// находится первый встреченный минимальный элемент.

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

int[,] DeleteTheRow(int[,] array)
{
    int[,] deletedRowArray = new int[array.GetLength(0) - 1, array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            deletedRowArray[i, j] = array[i + 1, j];
        }
    }
    return deletedRowArray;
}

int[,] InsertTheRow(int[,] deletedRowArray, int[,] initArray, int rowNumberMinElem)
{
    int[,] insertTheRowArray = new int[initArray.GetLength(0), initArray.GetLength(1)];
    for (int i = 0; i < initArray.GetLength(0); i++)
    {
        for (int j = 0; j < initArray.GetLength(0); j++)
        {
            if (i < rowNumberMinElem) insertTheRowArray[i, j] = deletedRowArray[i, j];
            if (i == rowNumberMinElem) insertTheRowArray[i, j] = initArray[0, j];
            if (i > rowNumberMinElem) insertTheRowArray[i, j] = deletedRowArray[i-1, j];
        }
    }
    return insertTheRowArray;
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

int[,] deletedRowArray = new int[array.GetLength(0) - 1, array.GetLength(1)];
deletedRowArray = DeleteTheRow(array);

Console.WriteLine(" ");

PrintArray(deletedRowArray);

Console.WriteLine(" ");

int rowNumberMinElem = SearchMin(array)/10;

Console.WriteLine(" ");

PrintArray(InsertTheRow(deletedRowArray, array, rowNumberMinElem));

Console.WriteLine(" ");