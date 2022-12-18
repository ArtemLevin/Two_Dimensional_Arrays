// Дана целочисленная матрица размера 5×5.
//  Переставить местами 4 и 5 строку.

int [,] twoDimArray = new int[5,5];
for(int i = 0; i < twoDimArray.GetLength(0); i++)
{
    for(int j = 0; j < twoDimArray.GetLength(0); j++)
    {
        twoDimArray[i,j] = new Random().Next(-10, 11);
        Console.Write("{0}\t", twoDimArray[i,j]);
    }
    Console.WriteLine(" ");
}

 for (int j = 0; j < twoDimArray.GetLength(1); j++)
{
    int temp = twoDimArray[3,j];
    twoDimArray[3,j] = twoDimArray[4,j];
    twoDimArray[4,j] = temp;
}

Console.WriteLine(" ");Console.WriteLine(" ");

for(int i = 0; i < twoDimArray.GetLength(0); i++)
{
    for(int j = 0; j < twoDimArray.GetLength(0); j++)
    {
        Console.Write("{0}\t", twoDimArray[i,j]);
    }
    Console.WriteLine(" ");
}
