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


int[,] matrix = CreateMatrix(rowsMatrix, columsMatrix, minimal, maximal);

bool CheckMatrix(int[,] matr)
{
       return  matrix.GetLength(0)==matrix.GetLength(1);
}

if (CheckMatrix(matrix)) PrintMatrix(ReplaseRowColums(matrix));
else System.Console.WriteLine("Невозможно поменять строки и столбцы");


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

int[,] ReplaseRowColums (int [,] matr)
{
int[,] newArray = new int [matr.GetLength(1), matr.GetLength(0)];
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        newArray [i,j] = matr[j,i];
    }
}
return newArray;
}
System.Console.WriteLine();
PrintMatrix(matrix);