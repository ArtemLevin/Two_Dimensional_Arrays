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
        Console.WriteLine(" ");
    }
    return twoDimArray;
}

int [,] twoDimArray = new int[5,5];
twoDimArray = CreateArray();
PrintArray(twoDimArray );
Console.WriteLine(" ");

int[,] SortingBubble (int[,] twoDimArray)
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

PrintArray(SortingBubble(twoDimArray));