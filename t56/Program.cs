/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. */

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


int MinRow(int[,] array)
{
    int min = 0;
    for (int z = 0; z < array.GetLength(0); z++)
    {
        min += array[z, 0];
    }
    int minRow = 0;
    System.Console.WriteLine($"Сумма эллиментов в строке № 1  = {min}");
    for (int i = 1; i < array.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        if (sum < min)
        {
            min = sum;
            minRow = i;
        }
        System.Console.WriteLine($"Сумма эллиментов в строке № {i + 1}  = {sum}");

    }
    minRow++;
    return minRow;
}


int[,] myArray = FillArray(5, 4, 10);
PrintArray(myArray, "My array");
System.Console.WriteLine($"Наименьшая сумма эллиментов в строке № {MinRow(myArray)}");