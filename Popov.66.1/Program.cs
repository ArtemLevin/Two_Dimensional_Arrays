// Отсортировать по возрастанию элементов
// последней строки целочисленный двухмерный массив 3×4.

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

int[,] AscendOrder(int[,] matrix, int line)
{
    int i = line;
    int max = matrix[i, 0];
    int temp;
    int j = 0;
    int k = 0;
    while (j < rows)
    {
        max = matrix[i, j];
        int p = j + 1;

        while (p < rows)
        {
            if (matrix[i, p] > max)
            {
                max = matrix[i, p];
                k = p;
            }
            p++;
        }
        if (j != rows-1 && matrix[i, j] < max)
        {
            temp = matrix[i, k];
            matrix[i, k] = matrix[i, j];
            matrix[i, j] = temp;
        }

        j++;

    }
    return matrix;
}

CreateTwoDimArray(lines, rows);
PrintTwoDimArray(matrix);
Console.Write("Computer prints the array... ");
Console.WriteLine(" ");
Console.Write("Computer sorts in ascending order the last line in the array... ");
Console.WriteLine(" ");
Console.Write("The computer prints the modified array... ");
Console.WriteLine(" ");
Console.Write("Enter the line number to sort... ");
int line = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");
PrintTwoDimArray(AscendOrder(matrix, line));

