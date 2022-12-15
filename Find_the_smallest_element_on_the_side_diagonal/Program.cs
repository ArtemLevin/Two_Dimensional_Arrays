


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

int MinOnsideDiag(int [,] matrix)
{
    int i = lines-1;
    int j = 0;
    int min = matrix[i,j];
    while (i>-1 || j < rows)
    {
        if(matrix[i,j]<min)
        {
         min=matrix[i,j];
        }
        i--;
        j++;
    }
    return min;
}
Console.WriteLine(" ");
Console.WriteLine("Min element on te side diagonale is " + MinOnsideDiag(matrix));
Console.WriteLine(" ");
