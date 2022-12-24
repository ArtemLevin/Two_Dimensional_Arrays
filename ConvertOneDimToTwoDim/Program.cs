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
            Console.Write("{0}	", array[i, j]);
        }
        Console.WriteLine(" ");
    }
}

void PrintOneDimArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0}	", array[i]);
    }
    Console.WriteLine(" ");
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

int[] TwoDimToOneDim(int[,] array)
{
    int index = 0;
    int[] OneDimArray = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            OneDimArray[index] = array[i, j];
            index++;
        }
    }
    return OneDimArray;
}

PrintOneDimArray(TwoDimToOneDim(array));
Console.WriteLine(" ");

int[,] ConvertOneDimToTwoDimArray(int[] array)
{
    Console.Write("Enter the number of rows in new array ");
    int newRows = int.Parse(Console.ReadLine()!);
    int p = 0;
    int[,] TwoDimArray = new int[newRows, (array.Length)/newRows];
    for (int i = 0; i < TwoDimArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoDimArray.GetLength(1); j++)
        {
            TwoDimArray[i, j] = array[p];
            p++;
        }
    }
    return TwoDimArray;
}

Console.WriteLine(" ");
PrintArray(ConvertOneDimToTwoDimArray(TwoDimToOneDim(array)));
