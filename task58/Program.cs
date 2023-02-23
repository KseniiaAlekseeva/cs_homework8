// Find the multiplicaion of two matrices

int[,] CreateMatrix(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,]? MultMatrix(int[,] matrix1, int[,] matrix2)
{
    int m, n, k;
    m = matrix1.GetLength(0);
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
        n = matrix1.GetLength(1);
    else
        n = 0;
    k = matrix2.GetLength(1);

    if (n > 0)
    {
        int[,] multMatr = new int[m, k];
        for (int i = 0; i < m; i++)
            for (int j = 0; j < k; j++)
                for (int ii = 0; ii < n; ii++)
                    multMatr[i, j] += matrix1[i, ii] * matrix2[ii, j];
        PrintMatrix(multMatr);
        return multMatr;
    }
    else
    {
        Console.WriteLine("The dimension n1 of matrix1 is not equal to dimension m1 of matrix2. Multiplication is impossible.");
        return null;
    }
}

Console.WriteLine("Enter the dimensions m*n of the first matrix: ");
string[] str = Console.ReadLine().Split(" ");

int m1 = Convert.ToInt32(str[0]);
int n1 = Convert.ToInt32(str[1]);

int[,] matr1 = CreateMatrix(m1, n1, 0, 9);
PrintMatrix(matr1);

Console.WriteLine("Enter the dimensions n*k of the second matrix: ");
str = Console.ReadLine().Split(" ");

int m2 = Convert.ToInt32(str[0]);
int n2 = Convert.ToInt32(str[1]);

int[,] matr2 = CreateMatrix(m2, n2, 0, 9);
PrintMatrix(matr2);

int[,] mult = MultMatrix(matr1, matr2);