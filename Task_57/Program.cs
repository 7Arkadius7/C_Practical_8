Console.Clear(); // метод замены столбцов и строк местами

Console.WriteLine("Пожалуйста, введите количество строк матрицы");
int rowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите количество столбцов матрицы");
int columsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите минимально возможный элемент матрицы");
int minimal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите максимально возможный элемент матрицы");
int maximal = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();


int[,] matrix = CreateMatrix(rowsMatrix, columsMatrix, minimal, maximal);
PrintMatrix(matrix);
System.Console.WriteLine();
int[] oneRowArray2D = MatrToOneRowArray(matrix);
PrintArray(oneRowArray2D);
System.Console.WriteLine();
Array.Sort(oneRowArray2D);
PrintArray(oneRowArray2D);
System.Console.WriteLine();
HowManyNumbersInArray(oneRowArray2D);

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

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) System.Console.Write($"{array[i]}, ");
        else System.Console.Write($"{array[i]}");
    }
    System.Console.Write("]");
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


int[] MatrToOneRowArray(int[,] matr)
{
    int[] oneRowArray = new int[matr.Length];
    int counter = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            oneRowArray[counter] = matr[i, j];
            counter++;
        }
    }
    return oneRowArray;
}

void HowManyNumbersInArray(int[] array)
{
    int count = 1;
    int numForCount = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(numForCount==array[i]) count++;
        else 
        {
            System.Console.WriteLine($"{numForCount} -> {count}");
            numForCount = array [i];
            count = 1;
        }
    }
    System.Console.WriteLine($"{numForCount} -> {count}");
}