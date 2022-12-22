// Дан массив фамилий студентов 1-го курса и массив их результатов в беге
// на 100 метров. Составьте команду из четырех лучших бегунов для участия в эстафете.

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == 0)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = j;
            }
        }
        if (i == 1)
        {
            for (int j = 0; j < columns; j++)
            {
                array[i, j] = new Random().Next(10, 51);
            }
        }
    }
    return array;
}
void PrintTDArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0}	", array[i, j]);
        }
        Console.WriteLine(" ");
    }
}

void PrintArray(int[] array)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0}\t", array[j]);
    }
    Console.WriteLine(" ");
}


Console.Write("Enter the number or rows...");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number or columns..");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");
int[,] array = new int[rows, columns];
array = CreateArray(rows, columns);
Console.WriteLine(" ");
PrintTDArray(array);
Console.WriteLine(" ");

int[] FourMinElements(int[,] array)
{
    int[] minNumbers = new int[4];
    int firstMinNumber = 0;
    int secondMinNumber = 0;
    int thirdMinNumber = 0;
    int forthMinNumber = 0;

    int min1 = array[1, 0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[1, j] < min1)
        {
            min1 = array[1, j];
            firstMinNumber = j;
        }
        minNumbers[0] = firstMinNumber;
    }
    int min2 = array[1, 0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[1, j] < min2 && j != firstMinNumber)
        {
            min2 = array[1, j];
            secondMinNumber = j;
        }
    }
    minNumbers[1] = secondMinNumber;
    int min3 = array[1, 0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[1, j] < min3 && j != firstMinNumber && j != secondMinNumber)
        {
            min3 = array[1, j];
            thirdMinNumber = j;
        }
    }
    minNumbers[2] = thirdMinNumber;
    int min4 = array[1, 0];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[1, j] < min4 && j != firstMinNumber && j != secondMinNumber && j != thirdMinNumber)
        {
            min4 = array[1, j];
            forthMinNumber = j;
        }
    }
    minNumbers[3] = forthMinNumber;
    return minNumbers;
}


PrintArray(FourMinElements(array));