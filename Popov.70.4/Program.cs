// Дана квадратная матрица. Сформировать одномерный массив, состоящий
// из элементов, расположенных ниже главной диагонали матрицы. Выполнить сортировку одномерного массива. Вывести матрицу, одномерный
// массив до сортировки, одномерный массив после сортировки.

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 11);
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
            Console.Write("{0}	", array[i, j]);
        }
        Console.WriteLine(" ");
    }
}

void PrintOneDimArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("{0}\t", array[i]);
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
PrintArray(array);
Console.WriteLine(" ");

int[] TwoDimToOneDim(int[,] array)
{
    int index = 0;
    int[] OneDimArray = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            OneDimArray[index] = array[i, j];
            index++;
        }
    }
    return OneDimArray;
}

PrintOneDimArray(TwoDimToOneDim(array));

