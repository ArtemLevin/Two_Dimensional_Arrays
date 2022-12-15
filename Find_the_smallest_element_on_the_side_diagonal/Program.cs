


int lines = 5;
int rows = 5;

Console.Write("Computer creates an array... ");

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
CreateTwoDimArray(lines, rows);
PrintTwoDimArray(matrix);


int i = lines-1;
int j = 0;
int max = matrix[i,j];

while (i>-1 || j < rows)
{
    if(matrix[i,j]>max)
    {
        max=matrix[i,j];
    }
    i--;
    j++;
}
Console.Write(max);