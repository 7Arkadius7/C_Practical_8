Console.Clear();

Console.WriteLine("Пожалуйста, введите количество строк первой матрицы");
int rowsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите количество столбцов первой матрицы");
int columsFirstMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите количество строк второй матрицы");
int rowsSecondMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите количество столбцов второй матрицы");
int columsSecondMatrix = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Пожалуйста, введите минимально возможный элемент матриц");
int minimal = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите максимально возможный элемент матриц");
int maximal = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();


int[,] firstMatrix = CreateMatrix(rowsFirstMatrix, columsFirstMatrix, minimal, maximal);
int[,] secondMatrix = CreateMatrix(rowsSecondMatrix, columsSecondMatrix, minimal, maximal);

PrintMatrix(firstMatrix);
System.Console.WriteLine();
PrintMatrix(secondMatrix);
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

int[,] MultiplyMatrix(int[,] matr1, int[,] matr2)
{
    int[,] resultMatr = new int[matr1.GetLength(0), matr2.GetLength(1)];

    for (int i = 0; i < matr1.GetLength(0); ++i)
        for (int j = 0; j < matr2.GetLength(1); ++j)
             for (int k = 0; k < matr2.GetLength(0); ++k)
                        resultMatr[i,j] += matr1[i,k] * matr2[k,j];

    return resultMatr;
}

if (firstMatrix.GetLength(0) != secondMatrix.GetLength(1))
{
    Console.WriteLine("Данные матрицы нельзя перемножить! ");
    return;
}
else PrintMatrix(MultiplyMatrix(firstMatrix, secondMatrix));