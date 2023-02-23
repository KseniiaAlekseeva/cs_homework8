// Write a program that will fill the array by a spiral

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

void FillArray(int[,] array, int minValue, int maxValue)
{
    int count = 0;

    int m = array.GetLength(0);
    int n = array.GetLength(1);

    int left = 0;
    int right = n - 1;
    int up = 0;
    int down = m - 1;

    int dir = 0;  // 0 - from left to right, 
                  // 1 - from up to down, 
                  // 2 - from right to left,
                  // 3 - from down to up
    while (((left <= right) && (up <= down)))
    {
        if (dir == 0)
        {
            for (int j = left; j <= right; j++)
                array[up, j] = new Random().Next(minValue, maxValue + 1);
            up++;
            dir = 1;
        }
        else
            if (dir == 1)
        {
            for (int i = up; i <= down; i++)
                array[i, right] = new Random().Next(minValue, maxValue + 1);
            right--;
            dir = 2;
        }
        else
             if (dir == 2)
        {
            for (int j = right; j >= left; j--)
                array[down, j] = new Random().Next(minValue, maxValue + 1);
            down--;
            dir = 3;
        }
        else
        {
            for (int i = down; i >= up; i--)
                array[i, left] = new Random().Next(minValue, maxValue + 1);
            left++;
            dir = 0;
        }
        count++;
        PrintArray(array);
    }
}

Console.WriteLine("Enter the dimension m*n of array: ");
string[] str = Console.ReadLine().Split(" ");

int m = Convert.ToInt32(str[0]);
int n = Convert.ToInt32(str[1]);

int[,] arr = new int[m, n];
FillArray(arr, 1, 9);
