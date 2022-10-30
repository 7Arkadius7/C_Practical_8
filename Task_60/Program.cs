Console.Clear();
Console.WriteLine("Пожалуйста, введите количество строк матрицы");
int rowsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите количество столбцов матрицы");
int columsMatrix = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Пожалуйста, введите глубину матрицы");
int deepMatrix = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine();

int[,,] matrix = new int[rowsMatrix, columsMatrix, deepMatrix];
CreatMatrix3D(ref matrix);
PrintMatrix3D(matrix);


void PrintMatrix3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); ++i)
    {
        for (int j = 0; j < matrix.GetLength(1); ++j)
        {
            for (int k = 0; k < matrix.GetLength(2); ++k)
                Console.Write("{0} ( {1}, {2}, {3} )  ", matrix[j, k, i], j, k, i);
            Console.WriteLine();
        }
    }
}


void CreatMatrix3D(ref int[,,] matrix)
{
    Random rnd = new Random();
    int[] count = new int[100];

    for (int i = 0; i < matrix.GetLength(0); ++i)
        for (int j = 0; j < matrix.GetLength(1); ++j)
            for (int k = 0; k < matrix.GetLength(2); ++k)
            {
                matrix[i, j, k] = rnd.Next(10, 99);
                while (count[matrix[i, j, k]] > 0)
                    matrix[i, j, k] = rnd.Next(10, 99);
                count[matrix[i, j, k]]++;
            }
}


