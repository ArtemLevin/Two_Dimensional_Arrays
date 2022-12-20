// Определить радиус и центр окружности, на которой лежит наибольшее
// число точек заданного на плоскости массива точек А(xi,yi)

int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 101);
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


int Circle(int[,] array, int coordX, int coordY, int Radius)
{
    int RadiusCalculated = 0;
    int count = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        RadiusCalculated = (array[0, j] - coordX) * (array[0, j] - coordX) + (array[1, j] - coordY) * (array[1, j] - coordY);
        if (Radius * Radius == RadiusCalculated) count++;
    }
    return count;
}

int rows = 2;
int columns = 500;
Console.WriteLine(" ");
int[,] array = new int[rows, columns];
array = CreateArray(rows, columns);
Console.WriteLine(" ");
// PrintArray(array);
Console.WriteLine(" ");

int maxcount = 0;
int x = 0, y = 0, R = 0;
for (int coordX = 0; coordX < 100; coordX++)
{
    for (int coordY = 0; coordY < 100; coordY++)
    {
        for (int Radius = 0; Radius < 100; Radius++)
        {
            int currentCount = Circle(array, coordX, coordY, Radius);
            if (currentCount > maxcount)
            {
                maxcount = currentCount;
                x = coordX;
                y = coordY;
                R = Radius;
            }
        }
    }
}

Console.Write("X = {0}, Y = {1}, R = {2}, Number of dots = {3}", x, y, R, maxcount);