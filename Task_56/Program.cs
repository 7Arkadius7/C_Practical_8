Console.Clear();

Console.WriteLine("Пожалуйста, введите количество строк матрицы");
int rowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите количество столбцов матрицы");
int columsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите минимально возможный элемент матрицы");
int minimal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите максимально возможный элемент матрицы");
int maximal = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();


int[,] CreateMatrix(int rows, int colums, int min, int max)
{
    int[,] matrix = new int[rows, colums];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        System.Console.Write(("["));
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j < matr.GetLength(1) - 1) System.Console.Write($"{matr[i, j],4}, ");
            else System.Console.Write($"{matr[i, j],4}");
        }
        System.Console.WriteLine(("]"));
    }
}


int[] SumOfLine(int[,] matr)
{
    int[] sum = new int[matr.GetLength(0)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum[i] = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum[i] += matr[i, j];
        }
    }
    return sum;
}


void ArrayPrint(int[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write($"{arr[j]}   ");
    }
}

int MinIndex(int[] arr)
{

    int minNum = arr[0];
    int index = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < minNum)
        {
            minNum = arr[i];
            index = i;
        }
    }
    return index;
}


int[,] matrix = CreateMatrix(rowsMatrix, columsMatrix, minimal, maximal);
PrintMatrix(matrix);
System.Console.WriteLine();
int[] sum = SumOfLine(matrix);
ArrayPrint(sum);
System.Console.WriteLine();
int minSum = MinIndex(sum);
Console.WriteLine($"Наименьшая сумма элементов в {minSum + 1} строке");