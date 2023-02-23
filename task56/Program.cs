// Create a two-dimensional array. Find the row with minimum sum of elements.

int[,] CreateArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int RowSum(int[,] array, int row)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        sum += array[row, j];
    return sum;
}

int Min(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;
}

Console.WriteLine("Enter the dimension m*n of array: ");
string[] str = Console.ReadLine().Split(" ");

int m = Convert.ToInt32(str[0]);
int n = Convert.ToInt32(str[1]);

int[,] arr = CreateArray(m, n, 0, 9);
PrintArray(arr);

int[] rows = new int[m];                 // array of the sum of the rows elements

for (int i = 0; i < arr.GetLength(0); i++)
    rows[i] = RowSum(arr, i);

for (int i = 0; i < arr.GetLength(0); i++)
    Console.WriteLine($"The sum for row {i} is {rows[i]}.");

int min = Min(rows);                      // minimum of the sum of the rows elements

List<int> list = new List<int>();     // list of the numbers of the rows with the minimum sum of elements

string st = "";
for (int i = 0; i < arr.GetLength(0); i++)
{
    if (rows[i] == min)
    {
        list.Add(i);

        if (st == "")
            st = st + i.ToString();
        else
            st = st + ", " + i.ToString();

    }
}

Console.WriteLine($"The minimum sum of row elements is {min} for rows {st}.");



