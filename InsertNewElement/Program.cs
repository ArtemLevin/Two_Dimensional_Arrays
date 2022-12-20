// Insert new element in the end of the array

int [,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(0, 11); 
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0}\t", array[i,j]);
        }
        Console.WriteLine("");
    }
}


Console.Write("Enter the number of rows...");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns...");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = new int[rows, columns];
array = CreateArray(rows, columns);

PrintArray(array);
Console.WriteLine("");

int[,] InsertElement(int[,] array, int element)
{
    int[,] newArray = new int[array.GetLength(0), array.GetLength(1)+1];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {   
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            if(j == array.GetLength(1)) newArray[i,j] = element;
            else newArray[i,j] = array[i,j];
        }
        
    }
    return newArray;
}

Console.WriteLine("");
PrintArray(InsertElement(array, 100));
