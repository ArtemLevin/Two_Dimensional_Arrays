// Console.WriteLine("Enter number of lines in triangles ");
// int rows = int.Parse(Console.ReadLine()!);

int[,] PascalTriangle(int rows)
{
    int columns = 2 * rows + 1;
    int[,] triangle = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 1; j < columns-1; j++)
        {
            if (i == 0 && j == rows) triangle[i, j] = 1;
            if (i > 0)
            {
                triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j + 1];
            }
        }
    }
    return triangle;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == 0) Console.Write(" \t");
            else Console.Write("{0}\t", array[i, j]);
        }
        Console.WriteLine(" ");
    }
}

PrintArray(PascalTriangle(10));

