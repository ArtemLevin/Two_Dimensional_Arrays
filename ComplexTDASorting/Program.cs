

int lines = 5;
int rows = 5;

Console.WriteLine("Computer creates an array... ");

int[,] CreateTwoDimArray(int lines, int rows)
{
    int[,] matrix = new int[lines, rows];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-100, 101);
        }
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
Console.Write("Computer prints the array... ");
Console.WriteLine(" ");
Console.WriteLine(" ");
CreateTwoDimArray(lines, rows);
PrintTwoDimArray(matrix);

int [,] ComplexSorting(int[,] matrix, int startNumLine, int startNumRow)
{
    int i = startNumLine;
    int j = startNumRow;
    int max = matrix[i, j];
    int k = startNumLine;
    int p = startNumRow;
    int temp;

    
    while (i < lines)
    { 
        while (j < rows)
        {
            if(matrix[i, j] > max)
            {
                k = i;
                p = j;
                max = matrix[k, p];
            }
            j++;
        }
        j = 0;
        i++;
    }

    temp = matrix[k, p];
    matrix[k, p] = matrix[startNumLine, startNumRow];
    matrix[startNumLine, startNumRow] = temp;

    startNumRow++;

    if(startNumLine == 4 && startNumRow == 4)
    {
        return matrix;
    }
    if(startNumRow > 4)
    {
        startNumLine++;
        startNumRow = 0;
    }

    return ComplexSorting(matrix, startNumLine, startNumRow);



}
Console.Write("Enter the line number of the element to exchange... ");
int startNumLine = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Enter the row number of the element to exchange... ");
int startNumRow = int.Parse(Console.ReadLine());
Console.WriteLine(" ");
Console.Write("Computer is sorting the array... ");
Console.WriteLine(" ");
PrintTwoDimArray(ComplexSorting(matrix, startNumLine, startNumRow));
