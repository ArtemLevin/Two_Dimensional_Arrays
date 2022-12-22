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

string FourMinElements(int[,] array, int groupSize)
{
    string minNumbers = "";
    int count = 0;
    int min = array[1, 0];
    int delta;
    int minDelta = 100;
    int tempMin = 0;
    int tempIndexJ = 0;
    int firstMinNumber = 0;
    int minNumber = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (array[1, j] < min)
        {
            min = array[1, j];
            firstMinNumber = j;
        }
    }
    minNumbers =Convert.ToString(firstMinNumber) + " ";

    while(count != groupSize-1)
    {
        minDelta = array[1,0]-min;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            delta = array[1,j] - min;
            if(minDelta>delta && array[1, j]>min)
            {
                minDelta = delta;
                tempMin = array[1,j];
                tempIndexJ = j;
            }
        }
        min = tempMin;
        Console.WriteLine(min);
        
        minNumber = tempIndexJ;
        minNumbers +=Convert.ToString(minNumber) + " ";
        count++;  
    }
    return minNumbers;
    // if (count == 4) return  minNumbers;
    // else return minNumbers + FourMinElements(array, minNumber) ;
}


Console.WriteLine(FourMinElements(array, 5));




