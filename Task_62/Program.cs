Console.Clear();

int n = 4;
int[,] matr = new int[n, n];

void CreatSpiralMatrix(int[,] matr)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= matr.GetLength(0) * matr.GetLength(1))
    {
        matr[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < matr.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= matr.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > matr.GetLength(1) - 1)
            j--;
        else
            i--;
    }
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


CreatSpiralMatrix(matr);
PrintMatrix(matr);