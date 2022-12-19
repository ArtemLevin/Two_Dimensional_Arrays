
Console.Write("Enter the spiral size ");
int n = int.Parse(Console.ReadLine()!);

int[,] SpiralArray(int n)
{
    int i = 0, j = n;
    int count = 0;
    int p = 0;
    int t = 1;
    int q = 0;
    int u =0;
    int[,] array = new int[n, n];
    while (true)
    { 
        u=0;    
        while (u<n-q)
        {
            if (n * n <= count) return array;
            j--;
            array[i, j] = n * n - count;
            Console.Write(" AAA i = {0}, j = {1}, count = {2}, arrayElement = {3}, u = {4}, q = {5}", i, j, count, array[i, j], u, q);
            Console.WriteLine(" ");
            count++;
            u++;
        }
        u=0;

        q++;       

        while (u<n-q)
        {
            if (n * n <= count) return array;
            i++;
            array[i, j] = n * n - count;
            Console.Write(" BBB i = {0}, j = {1}, count = {2}, arrayElement = {3}, u = {4}, q = {5}", i, j, count, array[i, j], u,q);
            Console.WriteLine(" ");
            count++;
            u++;
        }
        u=0;

        while (u<n-q)
        {
            if (n * n <= count) return array;
            j++;
            array[i, j] = n * n - count;
            Console.Write(" CCC i = {0}, j = {1}, count = {2}, arrayElement = {3}, u = {4}, q = {5}", i, j, count, array[i, j], u,q);
            Console.WriteLine(" ");
            count++;
            u++;
        }
        
        u=0;

        q++;

        while (u<n-q)
        {
            if (n * n <= count) return array;
            i--;
            array[i, j] = n * n - count;
            Console.Write(" DDD i = {0}, j = {1}, count = {2}, arrayElement = {3}, u = {4}, q = {5}", i, j, count, array[i, j], u,q);
            Console.WriteLine(" ");
            count++;
            u++;
        }

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

