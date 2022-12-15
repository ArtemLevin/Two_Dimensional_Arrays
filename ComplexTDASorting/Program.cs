

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
    int i = 0;
    int j = 0;
    int max = matrix[0, 0];
    int k=0;
    int p=0;
    int temp;
    int u = 0;
    int y = 0;
    int countRow = 1;
    if(startNumRow%4 == 0)
    {
        startNumLine+=1;
        startNumRow = 0;
    }
    while (i < lines)
    { 
        j = 0;
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
        i++;
    }

    temp = matrix[k, p];
    matrix[k, p] = matrix[startNumLine, startNumRow];
    matrix[startNumLine, startNumRow] = temp;

    return matrix;

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
