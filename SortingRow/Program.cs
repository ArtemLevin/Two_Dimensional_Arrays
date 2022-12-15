// Сортировка элементов массива в столбцах от заданного начального до заданного конечного

Console.Write("Computer selectes the number of lines... ");
int lines = new Random().Next(5, 10);
Console.WriteLine(" ");
Console.Write("Computer selectes the number of rows... ");
int rows = new Random().Next(5, 10);
Console.WriteLine(" ");

Console.Write("Computer creates an array... ");
// Console.WriteLine(" ");

int[,] CreateTwoDimArray(int lines, int rows)
{
    int[,] matrix = new int[lines, rows];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
        Console.WriteLine(" ");
    }
    return matrix;
}
void PrintTwoDimArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}

int[,] matrix = new int[lines, rows];
matrix = CreateTwoDimArray(lines, rows);

int[,] AscendOrder(int[,] matrix, int row, int finalRow)
{
    int j = row;
    
    int temp;
    int i = 0;
    int k = 0;
    while (i < lines)
    {
        int max = matrix[i, j];
        int p = i + 1;

        while (p < lines)
        {
            if (matrix[p, j] > max)
            {
                max = matrix[p, j];
                k = p;
            }
            p++;
        }
        if (i != lines-1 && matrix[i, j] < max)
        {
            temp = matrix[k, j];
            matrix[k, j] = matrix[i, j];
            matrix[i, j] = temp;
        }

        i++;

    }
    if (row<finalRow)
    {
        row++;
        return AscendOrder(matrix, row, finalRow);
    }
    else return matrix;
}

CreateTwoDimArray(lines, rows);
PrintTwoDimArray(matrix);
Console.Write("Computer prints the array... ");
Console.WriteLine(" ");
Console.Write("Computer sorts in ascending order the last line in the array... ");
Console.WriteLine(" ");
Console.Write("The computer prints the modified array... ");
Console.WriteLine(" ");
Console.Write("Enter the start row number to sort... ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");
Console.Write("Enter the fianl row number to sort... ");
int finalRow = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");
PrintTwoDimArray(AscendOrder(matrix, row, finalRow));