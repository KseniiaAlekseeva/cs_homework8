// Create a two-dimensional array. Sort the elements of each row in descending order.

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

void Swap(int[,] array, int i1, int j1, int i2, int j2)
{
    int cur = array[i1, j1];
    array[i1, j1] = array[i2, j2];
    array[i2, j2] = cur;
}

void BubbleSortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = array.GetLength(1);

        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = 0; j < count - 1; j++)
            {
                if (array[i, j] < array[i, j + 1])
                    Swap(array, i, j, i, j + 1);
            }
            count--;
        }
    }
}

void ShakerSortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int left = 0;
        int right = array.GetLength(1) - 1; // левая и правая границы сортируемой области массива
        bool flag = true;  // флаг наличия перемещений

        // Выполнение цикла пока левая граница не сомкнётся с правой
        // и пока в массиве имеются перемещения
        while ((left < right) && flag)
        {
            flag = false;
            for (int j = left; j < right; j++)      // двигаемся слева направо
            {
                if (array[i, j] < array[i, j + 1])  // если следующий элемент больше текущего, меняем их местами
                {
                    Swap(array, i, j, i, j + 1);
                    flag = true;                    // перемещения в этом цикле были
                }
            }
            right--;                                // сдвигаем правую границу на предыдущий элемент
            for (int j = right; j > left; j--)      //двигаемся справа налево
            {
                if (array[i, j - 1] < array[i, j])  // если предыдущий элемент меньше текущего, меняем их местами
                {
                    Swap(array, i, j, i, j - 1);
                    flag = true;                    // перемещения в этом цикле были
                }
            }
            left++;                                 // сдвигаем левую границу на следующий элемент
        }
    }
}

Console.WriteLine("Enter the dimension m*n of array: ");
string[] str = Console.ReadLine().Split(" ");

int m = Convert.ToInt32(str[0]);
int n = Convert.ToInt32(str[1]);

int[,] arr = CreateArray(m, n, 0, 20);
PrintArray(arr);

ShakerSortRows(arr);
PrintArray(arr);



