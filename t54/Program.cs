/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива. */
int[,] FillArray(int columns, int rows, int deviation)
{
    int[,] array = new int[columns, rows];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, deviation);
        }
    }
    return array;
}


void PrintArray(int[,] incomingArray, string arrayName)
{
    System.Console.WriteLine($"Вывод массива '{arrayName}':");
    for (int j = 0; j < incomingArray.GetLength(1); j++)
    {
        for (int i = 0; i < incomingArray.GetLength(0); i++)
        {
            System.Console.Write(incomingArray[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine("-----------------------------");
}


int[,] SortArray(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(0) - 1; k++)
        {
            for (int i = 1; i < array.GetLength(0) - k; i++)
            {
                if (array[i, j] > array[i - 1, j])
                {
                    int minValue = array[i - 1, j];
                    array[i - 1, j] = array[i, j];
                    array[i, j] = minValue;
                }
            }
        }
    }
    return array;
}


int[,] myArray = FillArray(5, 4, 10);
PrintArray(myArray, "My array");
myArray = SortArray(myArray);
PrintArray(myArray, "My sorted array");