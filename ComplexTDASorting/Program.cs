

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

int  ComplexSorting(int[,] matrix)
{
    int i = 0;
    int j = 0;
    int max = matrix[0, 0];
    int k=0;
    int p=0;
    int temp;
    int u = 0;
    int y = 0;
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
    // if(i < lines -1 && j < rows -1 && matrix[i,j] < max)
    // {
    //     temp = matrix[k, p];
    //     matrix[k, p] = matrix[i,j];
    //     matrix[i,j] = temp;
    // }
    return max;

}

// Console.Write("Computer is sorting the array... ");
// Console.WriteLine(" ");
Console.Write(ComplexSorting(matrix));