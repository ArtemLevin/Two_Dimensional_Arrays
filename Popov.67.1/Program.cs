// В произвольной матрице - отсортировать по убыванию элементы
// последовательности, расположенные после второго отрицательного числа.


int [,] CreateArray()
{
    int [,] twoDimArray = new int[5,5];
    for(int i = 0; i < twoDimArray.GetLength(0); i++)
    {
        for(int j = 0; j < twoDimArray.GetLength(0); j++)
        {
            twoDimArray[i,j] = new Random().Next(-10, 11);
        }
    }
    return twoDimArray;
}

int [,] twoDimArray = new int[5,5];
twoDimArray = CreateArray();
PrintArray(twoDimArray);
Console.WriteLine(" ");

int[,] SortingBubbleInRows (int[,] twoDimArray)
{
    for (int i = 0; i < twoDimArray.GetLength(0); i++)
    {
        for (int j = 1; j < twoDimArray.GetLength(1); j++)
        {
            for (int k = 0; k < twoDimArray.GetLength(1)-j; k++)
            {
                if (twoDimArray[i, k]>twoDimArray[i, k+1])
                {
                    int temp = twoDimArray[i, k+1];
                    twoDimArray[i, k+1] = twoDimArray[i, k];
                    twoDimArray[i, k] = temp;
                }
            }
        }
    }
    return twoDimArray;
}


int[,] SortingBubbleInColumns (int[,] twoDimArray)
{
    for (int i = 0; i < twoDimArray.GetLength(1); i++)
    {
        for (int j = 1; j < twoDimArray.GetLength(0); j++)
        {
            for (int k = 0; k < twoDimArray.GetLength(0)-j; k++)
            {
                if (twoDimArray[k, i]>twoDimArray[k+1, i])
                {
                    int temp = twoDimArray[k+1, i];
                    twoDimArray[k+1, i] = twoDimArray[k, i];
                    twoDimArray[k, i] = temp;
                }
            }
        }
    }
    return twoDimArray;
}


void PrintArray(int[,] twoDimArray)
{
    for(int i = 0; i < twoDimArray.GetLength(0); i++)
    {
        for(int j = 0; j < twoDimArray.GetLength(0); j++)
        {
            Console.Write("{0}\t", twoDimArray[i,j]);
        }
        Console.WriteLine(" ");
    }
}

PrintArray(SortingBubbleInRows(twoDimArray));

Console.WriteLine(" ");

PrintArray(SortingBubbleInColumns(twoDimArray));

int [] OneRowArray(int[,] twoDimArray)
{
    int i=0, j = 0, k = 0;

    int [] oneRow = new int[(twoDimArray.GetLength(0))*(twoDimArray.GetLength(1))];

    while (i < twoDimArray.GetLength(0))
    {
        j=0;
        while(j < twoDimArray.GetLength(1))
        {
            oneRow[k] = twoDimArray[i,j];
            k++;
            j++;
            if (j > twoDimArray.GetLength(1)-1) 
            {
                i++;
            }
        }
    }
    return oneRow;
}

void PrintOneRowArray (int[] oneRow)
{
    int k = 0; 
    while (k < oneRow.Length )
    {
        Console.Write ("{0}\t", oneRow[k]);
        k++;
    }
    
}
Console.WriteLine(" ");


PrintOneRowArray(OneRowArray(twoDimArray));

int[] SortingBubbleOneRow (int[] oneRow)
{

        for (int j = 1; j < oneRow.Length; j++)
        {
            for (int k = 0; k < oneRow.Length-j; k++)
            {
                if (oneRow[k]>oneRow[k+1])
                {
                    int temp = oneRow[k+1];
                    oneRow[k+1] = oneRow[k];
                    oneRow[k] = temp;
                }
            }
        }
        return oneRow;
}
Console.WriteLine(" ");


PrintOneRowArray(SortingBubbleOneRow(OneRowArray(twoDimArray))); 