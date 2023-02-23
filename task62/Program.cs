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
    // for (int i = 0; i < array.GetLength(0); i++)
    //     for (int j = 0; j < array.GetLength(1); j++)
    //         array[i, j] = new Random().Next(minValue, maxValue + 1);

    // while ((left < right) && flag)
    // {
    //     flag = false;
    //     for (int j = left; j < right; j++)      // двигаемся слева направо
    //     {
    //         if (array[i, j] < array[i, j + 1])  // если следующий элемент больше текущего, меняем их местами
    //         {
    //             Swap(array, i, j, i, j + 1);
    //             flag = true;                    // перемещения в этом цикле были
    //         }
    //     }
    //     right--;                                // сдвигаем правую границу на предыдущий элемент
    //     for (int j = right; j > left; j--)      //двигаемся справа налево
    //     {
    //         if (array[i, j - 1] < array[i, j])  // если предыдущий элемент меньше текущего, меняем их местами
    //         {
    //             Swap(array, i, j, i, j - 1);
    //             flag = true;                    // перемещения в этом цикле были
    //         }
    //     }
    //     left++;                                 // сдвигаем левую границу на следующий элемент
    // }

    int count = 0;

    int m = array.GetLength(0);
    int n = array.GetLength(1);

    int curRow = 0;
    int curCol = 0;
    int left = 0;
    int right = m - 1;
    int up = 0;
    int down = 0;

    int dir = 0;  // 0 - from left to right, 
                  // 1 - from up to down, 
                  // 2 - from right to left,
                  // 3 - from down to up

    while (count < 8 /*array.GetLength(0) * array.GetLength(1)*/)
    {




        if (dir == 0)
        {
            for (int j = curCol; j < n - curCol; j++)
                array[curRow, j] = new Random().Next(minValue, maxValue + 1);
            //curRow++;
            //left++;
            //right--;
            up++;
            dir = 1;
        }
        else
            if (dir == 1)
        {
            for (int i = curRow; i < m - curRow + 1; i++)
                array[i, n - curCol - 1] = new Random().Next(minValue, maxValue + 1);
            //curCol++;
            right--;
            dir = 2;
        }
        else
             if (dir == 2)
        {
            for (int j = n - curCol - 1; j > curCol - 1; j--)
                array[m - curRow - 1, j] = new Random().Next(minValue, maxValue + 1);
            //curRow++;
            down--;
            dir = 3;
        }
        else
        {
            for (int i = m - curRow; i > curRow; i--)
                array[i, curCol] = new Random().Next(minValue, maxValue + 1);
            //curCol++;
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
//PrintArray(arr);
