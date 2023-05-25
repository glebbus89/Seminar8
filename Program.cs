// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] CreateRandom2dArray()
{
    Console.Write("Input a quantity of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a quantity of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            array[i,j] = new Random().Next (minValue, maxValue + 1);

    return array;
} 
    
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*void ReverseArray(int[,] array)
{
    for(int i = 1; i < array.GetLength(0); i++)
        for(int j = 0; j < i; j++)
        {
            int temp = array[i,j];
            array[i,j] = array[j,i];
            array[j,i] = temp;
        }
}

int[,] array = CreateRandom2dArray();
Show2dArray(array);
ReverseArray(array);
Show2dArray(array);
*/

//Task 2. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
void RandomChangeRows(int[,] array, int row1, int row2)
{
    if (row1 < array.GetLength(0) && row2 < array.GetLength(0) && row1 >= 0 && row2 >= 0)
    {
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[row1, j];
        array[row1, j] = array[row2, j];
        array[row2, j] = temp;
    } 
    }
    else
        Console.WriteLine("Sorry, I cannot :c");
}

Console.WriteLine("Input first row, please ");
int row1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input row into change with first row, please ");
int row2 = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
RandomChangeRows(myArray, row1, row2);
Show2dArray(myArray);
*/

//Task 3. Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
/*
void DeleteRowAndColumn(int[,] array, int [] coord)
{
    for(int i = 0; i < array.GetLength(0); i ++) array[i,coord[1]] = 0;
    for(int j = 0; j < array.GetLength(1); j++) array[coord[0], j] = 0;
}
*/
/*
int[] MinimumElement (int[,] array)
{
    int min = array[0, 0];
    int minX = 0;
    int minY = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minX = i;
                minY = j;
            }
        }
    }
    int[] coord = { minX, minY };
    return coord;  
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
int[] result = MinimumElement(myArray);
DeleteRowAndColumn(myArray, result);
Show2dArray(myArray);
*/
