// Create the three-dimensional array. Print the array by rows indicating the indices of elements.

int[,,] CreateArray(int m, int n, int p, int minValue, int maxValue)
{
    int[,,] array = new int[m, n, p];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            for (int k = 0; k < p; k++)
                array[i, j, k] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        Console.WriteLine();
    }
    Console.WriteLine();
}


Console.WriteLine("Enter three dimension m, n and p of array: ");
string[] str = Console.ReadLine().Split(" ");

int m = Convert.ToInt32(str[0]);
int n = Convert.ToInt32(str[1]);
int p = Convert.ToInt32(str[2]);


int[,,] arr = CreateArray(m, n, p, 0, 20);
PrintArray(arr);
