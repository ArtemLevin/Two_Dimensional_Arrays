// В произвольной матрице - отсортировать по убыванию элементы 
// последовательности, расположенные после второго отрицательного числа.

Console.Write("Computer selectes the number of lines... ");
int lines = new Random().Next(5, 10);
Console.WriteLine(" ");
Console.Write("Computer selectes the number of rows... ");
int rows = new Random().Next(5, 10);
Console.WriteLine(" ");

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
            Console.Write("{0}\t", matrix[i, j]);
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

    if(startNumLine == lines -1 && startNumRow == rows -1)
    {
        return matrix;
    }
    if(startNumRow > rows -1)
    {
        startNumLine++;
        startNumRow = 0;
    }

    return ComplexSorting(matrix, startNumLine, startNumRow);



}

int TheSecondNegative(int[,] array)
{
    int i = 0, j = 0, counter = 0;
    int k = 0;
    while (i < array.GetLength(0))
    {
        j = 0;
        while (j < array.GetLength(1))
        {
            if(array[i,j] < 0) 
            {
                counter++;
                if (counter == 2)
                {
                    k = 10*i + j;
                    break;
                }
            }
            j++;
        }
        i++;
    }
    return k;
}

int startNumLine = TheSecondNegative(matrix)/10;
int startNumRow = TheSecondNegative(matrix)%10;


Console.WriteLine(" ");
Console.Write("Computer is sorting the array... ");
Console.WriteLine(" ");
PrintTwoDimArray(ComplexSorting(matrix, startNumLine, startNumRow));
