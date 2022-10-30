Console.Clear();

Console.WriteLine("Пожалуйста, введите количество строк матрицы");
int rowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите количество столбцов матрицы");
int columsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите минимально возможный элемент матрицы");
int minimal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите максимально возможный элемент матрицы");
int maximal = Convert.ToInt32(Console.ReadLine());


int[,] matrix = CreateMatrix(rowsMatrix, columsMatrix, minimal, maximal);

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

void NewArray(int[,] matr)
{
for (int j = 0; j < matr.GetLength(1); j++)
{
    int obj = matr[0,j];
    matr[0,j] = matr[matr.GetLength(0) -1, j];
    matr[matr.GetLength(0)-1, j] = obj;
}
}

PrintMatrix(matrix);
System.Console.WriteLine();
NewArray(matrix);
PrintMatrix(matrix);
