
Console.Write("Enter the spiral size ");
int n = int.Parse(Console.ReadLine()!);

int[,] SpiralArray(int n)
{
    int i = 0, j = n;
    int count = 0;
    int p = 1;
    int q = 0;
    int u = 0;
    int[,] array = new int[n, n];
    while (true)
    {      
        while (u < n - q)
        {
            if (n * n <= count) return array;
            if (p == 1) j--; 
            if (p == 2) i++;
            if (p == 3) j++;
            if (p == 4) i--;
            array[i, j] = n * n - count;
            count++;
            u++;
        }
        if(p==1 || p==3) q++;
        if(p==4) p = 0;
        u = 0;
        p++;
    }
    return array;
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

PrintTwoDimArray(SpiralArray(n));


